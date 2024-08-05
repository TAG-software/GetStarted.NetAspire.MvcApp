var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.GetStarted_NetAspire_MvcApp>("getstarted-netaspire-mvcapp");

builder.Build().Run();
