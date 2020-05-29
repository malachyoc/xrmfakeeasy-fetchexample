using MoC.Extensions.Tests;
using te = MoC.Workflow.Entities;
using Xunit;

namespace MoC.Workflow.OtherTests
{
    public class TypedEntityTests : TypedEntityTestBase
    {
        [Theory, InlineData(typeof(te.SystemUser))
            , InlineData(typeof(te.Team))
            , InlineData(typeof(te.TeamMembership))
            , InlineData(typeof(te.BusinessProcessFlowInstance))
            , InlineData(typeof(te.ProcessStage))
            , InlineData(typeof(te.Workflow))]
        public void Test(System.Type type)
        {
            TestCrmGetSet(type);
        }
    }
}
