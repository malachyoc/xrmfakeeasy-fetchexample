using Microsoft.Xrm.Sdk;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using Xunit;

namespace MoC.Extensions.Tests
{
    public abstract class TypedEntityTestBase
    {
        protected void TestCrmGetSet(Type typeToTest)
        {
            Entity newEntity = (Entity)Activator.CreateInstance(typeToTest);

            //Test Generic Values
            TestPropertyAccessors(newEntity);

            //Recreate Entity
            newEntity = (Entity)Activator.CreateInstance(typeToTest);

            //Add Property Changed Event Handler
            int eventHandlersTriggered = 0;
            EventInfo propertyChangedInfo = newEntity.GetType().GetEvent("PropertyChanged");
            Action<object, PropertyChangedEventArgs> propertyChangedDelegate = (object sender, PropertyChangedEventArgs e) => {
                eventHandlersTriggered++;
            };
            PropertyChangedEventHandler propertyChangedHandler = new PropertyChangedEventHandler(propertyChangedDelegate);
            propertyChangedInfo.AddEventHandler(newEntity, propertyChangedHandler);

            //Add Property Changing Event Handler
            EventInfo propertyChangingInfo = newEntity.GetType().GetEvent("PropertyChanging");
            Action<object, PropertyChangingEventArgs> propertyChangingDelegate = (object sender, PropertyChangingEventArgs e) => {
                eventHandlersTriggered++;
            };
            PropertyChangingEventHandler propertyChangingHandler = new PropertyChangingEventHandler(propertyChangingDelegate);
            propertyChangingInfo.AddEventHandler(newEntity, propertyChangingHandler);

            //Test Generic Values - this time they will trigger the event handlers
            TestPropertyAccessors(newEntity);
            Assert.True(eventHandlersTriggered > 0, "Event Handlers Not Triggered");

            //Test ReadOnly Values
            TestReadOnlyProperties(newEntity);
        }

        protected void TestPropertyAccessors(Entity newEntity) { 
            var typeToTest = newEntity.GetType();
            var properties = typeToTest.GetProperties()
                .Where(p => p.CanRead == true && p.CanWrite == true)
                .ToList();

            //Test Generic Values
            foreach (var property in properties)
            {
                var testData = GenerateTestData(property.PropertyType);
                if (testData != null)
                {
                    //Verify Initial Value does not match test value
                    var originalValue = property.GetValue(newEntity);
                    Assert.NotEqual(testData, originalValue);

                    //Set test value
                    property.SetValue(newEntity, testData, null);
                    var updatedValue = property.GetValue(newEntity);

                    //Confirm Retrieved Value matches updated value
                    Assert.Equal(testData, updatedValue);

                    bool canBeNull = !property.PropertyType.IsValueType || (Nullable.GetUnderlyingType(property.PropertyType) != null);
                    if (canBeNull)
                    {
                        property.SetValue(newEntity, null, null);
                        updatedValue = property.GetValue(newEntity);

                        if (property.PropertyType.Name == nameof(Guid))
                        {
                            Assert.True((Guid)updatedValue == Guid.Empty, $"{newEntity.LogicalName}.{property.Name} expected to be Guid.Empty");
                        }
                        else
                        {
                            Assert.True(updatedValue == null, $"{newEntity.LogicalName}.{property.Name} expected to be NULL");
                        }
                    }
                }
            }
        }

        protected void TestReadOnlyProperties(Entity newEntity)
        {
            var typeToTest = newEntity.GetType();
            var properties = typeToTest.GetProperties()
                    .Where(p => p.CanRead == true && p.CanWrite == false)
                    .ToList();
            
            //Test Generic Values
            foreach (var property in properties)
            {
                var testData = GenerateTestData(property.PropertyType);
                if (testData != null)
                {
                    //Verify Initial Value does not match test value
                    var originalValue = property.GetValue(newEntity);
                    Assert.NotEqual(testData, originalValue);

                    //Set test value
                    object[] customAttributes = property.GetCustomAttributes(false);
                    if(customAttributes.Length == 1)
                    { 
                        AttributeLogicalNameAttribute logicalNameAttribute = customAttributes[0] as AttributeLogicalNameAttribute;
                        if (logicalNameAttribute != null)
                        {
                            //Set Attribute Value directly
                            newEntity.Attributes[logicalNameAttribute.LogicalName] = testData;

                            //Confirm Property value matches test value
                            var updatedValue = property.GetValue(newEntity);
                            Assert.Equal(testData, updatedValue);
                        }
                    }
                }
            }
        }

        protected Object GenerateTestData(Type testDataType)
        {
            if(testDataType.BaseType == typeof(Entity))
            {
                Entity newEntity = (Entity)Activator.CreateInstance(testDataType);
                newEntity.Id = Guid.NewGuid();

                return newEntity;
            }
            else if(testDataType.IsGenericType && typeof(IEnumerable).IsAssignableFrom(testDataType))
            {
                var entityType = testDataType.GetGenericArguments().FirstOrDefault();
                //Get the Entity Type
                if (typeof(Entity).IsAssignableFrom(entityType))
                {
                    Entity newEntity = (Entity)Activator.CreateInstance(entityType);

                    Type listType = typeof(List<>).MakeGenericType(entityType);
                    IList typedList = (IList)Activator.CreateInstance(listType);
                    typedList.Add(newEntity);
                    return typedList;
                }
            }

            Type typeToTest = testDataType.IsGenericType 
                ? Nullable.GetUnderlyingType(testDataType)
                : testDataType;

            if (typeToTest == null)
            {
                return null;
            }

            if (typeToTest.IsEnum)
                return Enum.ToObject(typeToTest, 0);
           
            switch (typeToTest.Name)
            {
                case nameof(String):
                    return "Test String";

                case nameof(OptionSetValue):
                    return new OptionSetValue(101);

                case nameof(Guid):
                    return Guid.NewGuid();

                case nameof(Boolean):
                    return true;

                case nameof(Int32):
                    return (Int32)400957;

                case nameof(EntityReference):
                    return new EntityReference("ImaginaryEntity", Guid.NewGuid());

                case nameof(DateTime):
                    return DateTime.Now;

                case nameof(Double):
                    return Math.PI;

                case nameof(Int64):
                    return (Int64)(Math.PI * 1000000000);

                case nameof(Decimal):
                    return (Decimal)(Math.PI * 1000000000000);

                case nameof(Money):
                    return new Money((decimal)(Math.PI * 2000000));

                case "Byte[]":
                    return Encoding.ASCII.GetBytes("This should be an encoded image");

                case nameof(BooleanManagedProperty):
                    return new BooleanManagedProperty(false);

                default:
                        return null;
                    //throw new ApplicationException($"Unknown Type: {typeToTest.Name}");
            }            
        }
    }
}
