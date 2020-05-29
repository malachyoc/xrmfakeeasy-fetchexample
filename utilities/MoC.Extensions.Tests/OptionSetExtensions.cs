using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchXmlWorkflow.Tests
{
    public static class OptionSetExtensions
    {
        public static List<OptionMetadata> CreateLabelsFromEnum(Type enumType)
        {
            List<OptionMetadata> optionsetList = new List<OptionMetadata>();
            foreach (var enumItem in Enum.GetValues(enumType))
            {
                string name = Enum.GetName(enumType, enumItem);
                int value = (int)enumItem;

                OptionMetadata optionset = new OptionMetadata(value);
                optionset.Label = new Label(name, 0);
                optionset.Label.UserLocalizedLabel = new LocalizedLabel(name, 0);
                optionsetList.Add(optionset);
            }
            return optionsetList;
        }
    }
}
