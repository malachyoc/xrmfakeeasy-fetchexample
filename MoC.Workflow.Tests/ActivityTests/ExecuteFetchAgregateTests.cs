using FakeXrmEasy;
using Microsoft.Xrm.Sdk;
using MoCEnergy.Workflows.Activities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xunit;
using te = MoC.TypedEntities;

namespace MoC.Workflow.ActivityTests
{
    public class ContactCountActivityTests
    {
        [Fact]
        public void CountTest()
        {
            var fakedContext = new XrmFakedContext();
            var wfContext = fakedContext.GetDefaultWorkflowContext();
            wfContext.MessageName = "Update";

            //Configure entity Metadata - this has to be done to use XrmFakeEasy with fetch query and
            //the underlying CRM Data structure needs to be known to properly mock the FetchQuery
            //
            //In this case I am using typed entites from an external library - if you are using Fetch you are probably
            //not using typed entites and do not want you Workflow / Plugin to be bloated by including in that assembley
            fakedContext.InitializeMetadata(typeof(MoC.TypedEntities.Contact).Assembly);
            Guid caseId = Guid.Parse("00000000-2222-0000-0000-FFFFFFFFFFFF");

            wfContext.PrimaryEntityName = te.Contact.EntityLogicalName;
            wfContext.PrimaryEntityId = caseId;

            List<Entity> entities = new List<Entity>();
            entities.Add(new te.Contact() {
                Id = Guid.NewGuid()
                , FirstName = "Joe"
                , LastName = "Soap"
            });

            entities.Add(new te.Contact()
            {
                Id = Guid.NewGuid()
                , FirstName = "Joe"
                , LastName = "Rogan"
            });

            entities.Add(new te.Contact()
            {
                Id = Guid.NewGuid()
                , FirstName = "John"
                , LastName = "Smith"
            });

            entities.Add(new te.Account() { 
                Id = Guid.NewGuid()
                , Name = "Test Account"
            });

            fakedContext.ProxyTypesAssembly = typeof(te.Account).Assembly;
            fakedContext.Initialize(entities);

            IOrganizationService crmService = fakedContext.GetOrganizationService();
            
            var inputs = new Dictionary<string, object>();
            inputs.Add(nameof(ContactCountActivity.FirstNameArgument), "Joe");

            ContactCountActivity codeActivity = new ContactCountActivity();
            var result = fakedContext.ExecuteCodeActivity<ContactCountActivity>(wfContext, inputs, codeActivity);
            Assert.True(result.ContainsKey(nameof(ContactCountActivity.NumberOfRecordsArgument)));
            var resultArgument = result[nameof(ContactCountActivity.NumberOfRecordsArgument)];
            Assert.Equal(2 , resultArgument);
        }
   }
}
