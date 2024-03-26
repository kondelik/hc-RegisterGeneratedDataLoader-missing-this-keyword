using HCMissingThis;

var builder = WebApplication.CreateBuilder(args);

builder.Services
  .AddGraphQLServer()
  .AddType<FooType>()
  // its not Extension Method
  //.RegisterGeneratedDataLoader()
  ;

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
