var builder = DistributedApplication.CreateBuilder(args);

builder.AddAzureFunctionsProject<Projects.AspireApp1_FunctionApps>("aspireapp1-functionapps");

builder.Build().Run();
