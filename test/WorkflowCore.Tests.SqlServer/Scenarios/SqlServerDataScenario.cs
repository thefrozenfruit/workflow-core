﻿using System;
using Microsoft.Extensions.DependencyInjection;
using WorkflowCore.IntegrationTests.Scenarios;
using Xunit;

namespace WorkflowCore.Tests.SqlServer.Scenarios
{
    [Collection(SqlServerCollection.Name)]
    public class SqlServerDataScenario : DataIOScenario
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddWorkflow(x => x.UseSqlServer(SqlDockerSetup.ScenarioConnectionString, true, true));
        }
    }

    [Collection(SqlServerCollection.Name)]
    public class OptimizedSqlServerDataScenario : DataIOScenario
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services.AddWorkflow(x => x.UseSqlServer(SqlDockerSetup.ScenarioConnectionString, true, true, true));
        }
    }
}
