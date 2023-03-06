# ASP.Net-Core-Middleware

What is Middleware?

Middleware is software that's assembled into an app pipeline to handle requests and responses. Each component:
-Chooses whether to pass the request to the next component in the pipeline.
-Can perform work before and after the next component in the pipeline.
Request delegates are used to build the request pipeline. The request delegates handle each HTTP request.

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0

Sedtup:

1.apply identity migrations
dotnet ef migrations add 

2.update database
dotnet ef database update

3.Run site and register a user

4.Edit ASpNetUsers table setting EmailConfirmed to true

5.edit appsettings.Development.json - 

{
  "Logging": {
    "LogLevel": {
      "Default": "Trace",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}

to ensure all log levels are visible.


Two examplE epieces of middleware:

ExampleMiddleware - merely logs output to the debug output window for all requests
