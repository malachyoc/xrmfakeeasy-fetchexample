namespace Utilities.CodeGeneration
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Crm.Services.Utility;
    using Microsoft.Xrm.Sdk.Metadata;
    using System.Xml.Linq;

    public sealed class OptionsetFilteringService : ICodeWriterFilterService
    {
        public const string CONST_FILTER_FILENAME = "filter.xml";

        //list of entity names to generate classes for.
        private HashSet<string> _validEntities = new HashSet<string>();
        private ICodeWriterFilterService DefaultService { get; set; }

        public OptionsetFilteringService(ICodeWriterFilterService defaultService)
        {
            DefaultService = defaultService;
            LoadFilterData();
        }

        /// <summary>
        /// loads the entity filter data from the filter.xml file
        /// </summary>
        private void LoadFilterData()
        {
            try
            {
                XElement xml = XElement.Load(CONST_FILTER_FILENAME);
                XElement entitiesElement = xml.Element("entities");

                foreach (XElement entityElement in entitiesElement.Elements("entity"))
                    _validEntities.Add(entityElement.Value.ToLowerInvariant());
            }
            catch
            {

            }
        }

        public bool GenerateOptionSet(OptionSetMetadataBase optionSetMetadata, IServiceProvider services)
        {
            return false;
        }

        public bool GenerateOption(OptionMetadata optionMetadata, IServiceProvider services)
        {
            return false;
        }

        public bool GenerateAttribute(AttributeMetadata attributeMetadata, IServiceProvider services)
        {
            switch (attributeMetadata.AttributeType.Value)
            {
                case AttributeTypeCode.Boolean:
                case AttributeTypeCode.Picklist:
                case AttributeTypeCode.State:
                case AttributeTypeCode.Status:
                    return true;
                default:
                    return false;
            }
        }

        public bool GenerateEntity(EntityMetadata entityMetadata, IServiceProvider services)
        {
            if(_validEntities.Contains(entityMetadata.LogicalName.ToLowerInvariant()) == true
                || _validEntities.Count == 0)
                return DefaultService.GenerateEntity(entityMetadata, services);
            else
                return false;
        }

        public bool GenerateRelationship(RelationshipMetadataBase relationshipMetadata, EntityMetadata otherEntityMetadata, IServiceProvider services)
        {
            return false;
        }

        public bool GenerateServiceContext(IServiceProvider services)
        {
            return false;
        }
    }
}
