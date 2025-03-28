﻿using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace HospitalModuleAccount.ArchitectureTests.Application
{
    public class ArchTestHandler
    {
        private static readonly Architecture Architecture = new ArchLoader().LoadAssemblies(
           System.Reflection.Assembly.Load("HospitalModuleAccount.Application")
       ).Build();

        [Fact]
        public void LosManejadoresDebenEstarEnCommandYQuery()
        {
            var portNamespacePatternCommandHandler = "HospitalModuleAccount.Application.*.CommandHandler";
           

            Classes()
            .That()
            .ResideInNamespace(portNamespacePatternCommandHandler, true)
            .Should()
            .HaveNameEndingWith("Handler")
            .OrShould()
            .HaveNameEndingWith("Command")
            .Because("Los manejadores deben estar en la capa de aplicaci�n y deben tener nombres que terminen con 'Handler'")
            .Check(Architecture);
        }
    }
}
