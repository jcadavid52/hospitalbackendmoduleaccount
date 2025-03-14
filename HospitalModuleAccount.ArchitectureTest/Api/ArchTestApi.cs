using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using MediatR;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace HospitalModuleAccount.ArchitectureTests.Api
{
    public class ArchTestApi
    {
        private static readonly Architecture Architecture = new ArchLoader().LoadAssemblies(
           System.Reflection.Assembly.Load("HospitalModuleAccount.Api")
       ).Build();

        [Fact]
        public void Api_ShouldUseMediatorForRequests2()
        {
            var apiHandlerClasses = Classes()
                .That().ResideInNamespace("HospitalModuleAccount.Api.ApiHandlers", true)
                .And().DoNotHaveNameEndingWith("Validator");

            var rule = apiHandlerClasses.Should().DependOnAny(typeof(IMediator));
            rule.Check(Architecture);
        }
    }
}
