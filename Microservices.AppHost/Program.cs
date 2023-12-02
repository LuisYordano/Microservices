var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.backend>("backend");

builder.AddProject<Projects.frontend>("frontend").WithReference(api);

builder.Build().Run();
