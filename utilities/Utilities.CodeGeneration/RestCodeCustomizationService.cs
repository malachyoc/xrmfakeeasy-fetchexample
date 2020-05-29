// Define REMOVE_PROXY_TYPE_ASSEMBLY_ATTRIBUTE if you plan on compiling the output from
// this CrmSvcUtil extension with the output from the unextended CrmSvcUtil in the same
// assembly (this assembly attribute can only be defined once in the assembly).
#define REMOVE_PROXY_TYPE_ASSEMBLY_ATTRIBUTE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.CodeGeneration
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using Microsoft.Crm.Services.Utility;

    public sealed class RestCodeCustomizationService : ICustomizeCodeDomService
    {
        /// <summary>
        /// Generate light weight class for use with REST endpoint
        /// </summary>
        public void CustomizeCodeDom(CodeCompileUnit codeUnit, IServiceProvider services)
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
                        //codeTypeDeclaration.Name = string.Format("{0}Attribute", codeTypeDeclaration.Name);

                        codeTypeDeclaration.CustomAttributes.Clear();
                        codeTypeDeclaration.BaseTypes.Clear();

                        List<string> attributes = new List<string>();
                        for (var j = 0; j < codeTypeDeclaration.Members.Count; )
                        {
                            if (codeTypeDeclaration.Members[j].GetType() == typeof(System.CodeDom.CodeMemberProperty) 
                                && codeTypeDeclaration.Members[j].CustomAttributes.Count > 0 
                                && codeTypeDeclaration.Members[j].CustomAttributes[0].AttributeType.BaseType == "Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute")
                            {

                                string attribute = ((System.CodeDom.CodePrimitiveExpression)codeTypeDeclaration.Members[j].CustomAttributes[0].Arguments[0].Value).Value.ToString();
                                bool nullable = false;

                                if (!attributes.Contains(attribute))
                                {
                                    attributes.Add(attribute);
                                    CodeMemberProperty memberJ = (CodeMemberProperty)codeTypeDeclaration.Members[j];
                                    memberJ.CustomAttributes.Clear();

                                    var fieldType = memberJ.Type;
                                    fieldType.BaseType = fieldType.BaseType.Replace("Microsoft.Xrm.Sdk.", "CrmRestApi.");
                                    IEnumerable <CodeTypeReference> typeArguments = fieldType.TypeArguments.Cast<CodeTypeReference>();

                                    if (typeArguments.Count() > 0)
                                    {
                                        fieldType = typeArguments.FirstOrDefault();
                                        nullable = true;
                                    }

                                    //Do not remove the attribute
                                    var codeMemberField = new CodeMemberField
                                    {
                                        Attributes = MemberAttributes.Public | MemberAttributes.Final,
                                        Name = string.Format("{0}", attribute),
                                        Type = new CodeTypeReference(nullable ? String.Format("Nullable<{0}>", fieldType.BaseType) : fieldType.BaseType),
                                    };
                                    //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
                                    codeMemberField.CustomAttributes.Add(
                                        new CodeAttributeDeclaration {
                                            Name = "JsonProperty"
                                            , Arguments = {
                                                new CodeAttributeArgument
                                                {
                                                    Name = "NullValueHandling"
                                                    , Value = new CodeFieldReferenceExpression( new CodeTypeReferenceExpression("NullValueHandling"), "Ignore")
                                                }}
                                        });
                                    codeTypeDeclaration.Members[j] = codeMemberField;
                                    j++;
                                }
                                else
                                {
                                    codeTypeDeclaration.Members.RemoveAt(j);
                                }
                            }
                            else if (codeTypeDeclaration.Members[j].GetType() == typeof(System.CodeDom.CodeMemberField))
                            {
                                //Skip
                                j++;
                                //codeTypeDeclaration.Members.RemoveAt(j);
                            }
                            else 
                            {
                                codeTypeDeclaration.Members.RemoveAt(j);
                            }
                        }

                        i++;
                    }
                    else if(codeTypeDeclaration.IsEnum)
                    {
                        //Do nothing
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

            CodeNamespace globalNamespace = new CodeNamespace();
            globalNamespace.Imports.Add(new CodeNamespaceImport("System"));
            globalNamespace.Imports.Add(new CodeNamespaceImport("Newtonsoft.Json"));

            codeUnit.Namespaces.Add(globalNamespace);
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
    }

}
