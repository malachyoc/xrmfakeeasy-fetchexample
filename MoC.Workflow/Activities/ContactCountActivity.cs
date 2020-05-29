using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Linq;

namespace MoCEnergy.Workflows.Activities
{

    public class ContactCountActivity : CodeActivity
    {
        [Input("First Name")]
        [ArgumentDescription("Name to Search for")]
        public InArgument<String> FirstNameArgument { set; get; }

        [Output("Number of Records")]
        [ArgumentDescription("The number of records found")]
        public OutArgument<int> NumberOfRecordsArgument { set; get; }

        protected override void Execute(CodeActivityContext context)
        {
            IWorkflowContext workflowContext = context.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = context.GetExtension<IOrganizationServiceFactory>();
            ITracingService trace = context.GetExtension<ITracingService>();

            IOrganizationService service = serviceFactory.CreateOrganizationService(null);

            //Get BPF Stage by Name or Guid
            trace.Trace("Getting input parameters");
            string inputValue = FirstNameArgument.Get<string>(context);
            trace.Trace($"Input Value: { inputValue }");

            //Execute Fetch Query
            string fetchString = @"<fetch aggregate='true' >
                  <entity name='contact' >
                    <attribute name='firstname' alias='recordcount' aggregate='count' />
                    <filter type='and' >
                      <condition attribute='firstname' operator='eq' value='" + inputValue + "" + @"' />
                    </filter>
                  </entity>
                </fetch>";

            EntityCollection result = service.RetrieveMultiple(new FetchExpression(fetchString));
            
            Entity fetchResult = result.Entities.FirstOrDefault();
            AliasedValue recordcount = (AliasedValue)fetchResult.Attributes["recordcount"];

            NumberOfRecordsArgument.Set(context, (int)recordcount.Value);
        }
    }
}
