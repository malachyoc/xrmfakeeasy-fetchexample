// Define REMOVE_PROXY_TYPE_ASSEMBLY_ATTRIBUTE if you plan on compiling the output from
// this CrmSvcUtil extension with the output from the unextended CrmSvcUtil in the same
// assembly (this assembly attribute can only be defined once in the assembly).
#define REMOVE_PROXY_TYPE_ASSEMBLY_ATTRIBUTE


namespace Utilities.CodeGeneration
{
    using Microsoft.Crm.Services.Utility;
    using System;
    using System.CodeDom;
    using System.Collections.Generic;

    public static class CodeCustomizationService
    {
        public static void MarkAsStaticClassWithExtensionMethods(CodeTypeDeclaration class_)
        {
            class_.Attributes = MemberAttributes.Public;

            class_.StartDirectives.Add(new CodeRegionDirective(
                    CodeRegionMode.Start, Environment.NewLine + "\tstatic"));

            class_.EndDirectives.Add(new CodeRegionDirective(
                    CodeRegionMode.End, string.Empty));
        }

        private static string GetParameter(string key)
        {
            string[] args = Environment.GetCommandLineArgs();
            foreach (string arg in args)
            {
                string[] argument = arg.Split(new char[] { ':' }, 2);
                if (argument.Length == 2 && argument[0].ToLowerInvariant() == key.ToLowerInvariant())
                {
                    return argument[1].Trim(new char[] { '"' });
                }
            }

            return null;
        }

        public static void GenerateCode(CodeCompileUnit codeUnit, IServiceProvider services, bool generateLogicalNames)
        {
            Console.WriteLine("Executing: Customised Attributes");

            string baseTypes = GetParameter("/basetypes");

            foreach (CodeNamespace codeNamespace in codeUnit.Namespaces)
            {
                for (int i = 0; i < codeNamespace.Types.Count;)
                {
                    CodeTypeDeclaration codeTypeDeclaration = codeNamespace.Types[i];

                    if (codeTypeDeclaration.IsClass)
                    {
                        MarkAsStaticClassWithExtensionMethods(codeTypeDeclaration);

                        if(generateLogicalNames)
                            codeTypeDeclaration.Name = string.Format("{0}LogicalNames", codeTypeDeclaration.Name);
                        else
                            codeTypeDeclaration.Name = string.Format("{0}Properties", codeTypeDeclaration.Name);

                        codeTypeDeclaration.CustomAttributes.Clear();
                        codeTypeDeclaration.BaseTypes.Clear();

                        List<string> attributes = new List<string>();
                        for (var j = 0; j < codeTypeDeclaration.Members.Count;)
                        {
                            if (codeTypeDeclaration.Members[j].GetType() == typeof(System.CodeDom.CodeMemberProperty)
                                && codeTypeDeclaration.Members[j].CustomAttributes.Count > 0
                                && codeTypeDeclaration.Members[j].CustomAttributes[0].AttributeType.BaseType == "Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute")
                            {
                                string attribute = ((System.CodeDom.CodePrimitiveExpression)codeTypeDeclaration.Members[j].CustomAttributes[0].Arguments[0].Value).Value.ToString();

                                if (!attributes.Contains(attribute))
                                {
                                    var memberJ = codeTypeDeclaration.Members[j];
                                    attributes.Add(attribute);

                                    CodePrimitiveExpression attributeValue;

                                    if (generateLogicalNames)
                                        attributeValue = new CodePrimitiveExpression(attribute);
                                    else
                                        attributeValue = new CodePrimitiveExpression(memberJ.Name);

                                    codeTypeDeclaration.Members[j] = new CodeMemberField
                                        {
                                            Attributes = MemberAttributes.Public | MemberAttributes.Const,
                                            Name = string.Format("{0}", attribute),
                                            Type = new CodeTypeReference(typeof(System.String)),
                                            InitExpression = attributeValue
                                    };
                                    j++;
                                }
                                else
                                {
                                    codeTypeDeclaration.Members.RemoveAt(j);
                                }
                            }
                            else
                            {
                                codeTypeDeclaration.Members.RemoveAt(j);
                            }
                        }

                        i++;
                    }
                    else
                    {
                        //Only intereseted in Entities
                        codeNamespace.Types.RemoveAt(i);
                    }
                }
            }

            foreach (CodeAttributeDeclaration attribute in codeUnit.AssemblyCustomAttributes)
            {
                if (attribute.AttributeType.BaseType == "Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute")
                {
                    codeUnit.AssemblyCustomAttributes.Remove(attribute);
                    break;
                }
            }
        }

    }

    public sealed class LogicalNameCustomizationService : ICustomizeCodeDomService
    {
        /// <summary>
        /// Replace all properties with attribute constants
        /// Remove all unnecessary class members
        /// </summary>
        public void CustomizeCodeDom(CodeCompileUnit codeUnit, IServiceProvider services)
        {
            CodeCustomizationService.GenerateCode(codeUnit, services, true);
        }
    }

    public sealed class PropertyNameCustomizationService : ICustomizeCodeDomService
    {
        /// <summary>
        /// Replace all properties with attribute constants
        /// Remove all unnecessary class members
        /// </summary>
        public void CustomizeCodeDom(CodeCompileUnit codeUnit, IServiceProvider services)
        {
            CodeCustomizationService.GenerateCode(codeUnit, services, false);
        }
    }
}
