﻿using System;
using Microsoft.Extensions.DependencyInjection;
using WorkflowCore.IntegrationTests.Scenarios;
using Xunit;

namespace WorkflowCore.Tests.PostgreSQL.Scenarios
{
    [Collection(PostgresCollection.Name)]
    public class PostgresWhenScenario : WhenScenario<PostgresWhenScenario>
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddWorkflow(x => x.UsePostgreSQL(PostgresDockerSetup.ScenarioConnectionString, true, true));
        }
    }

    [Collection(PostgresCollection.Name)]
    public class OptimizedPostgresWhenScenario : WhenScenario<OptimizedPostgresWhenScenario>
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddWorkflow(x => x.UsePostgreSQL(PostgresDockerSetup.ScenarioConnectionString, true, true, true));
        }
    }
}
