var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebApiExample>("webapiexample");

builder.Build().Run();
