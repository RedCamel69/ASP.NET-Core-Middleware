# ASP.Net-Core-Middleware

What is Middleware?

Middleware is software that's assembled into an app pipeline to handle requests and responses. Each component:
  -Chooses whether to pass the request to the next component in the pipeline.
  -Can perform work before and after the next component in the pipeline.
Request delegates are used to build the request pipeline. The request delegates handle each HTTP request.

https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-8.0

Setup:
*****

1.apply identity migrations
dotnet ef migrations add 

2.update database
dotnet ef database update

3.Run site and navigate between pages. Proceed to register a user.

4.Edit AspNetUsers table setting EmailConfirmed to true or click the confirm dialog after registering.

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


Two example epieces of middleware:

LogLevelsMiddleware - merely logs an example of each loglevel output to the debug output window for all requests
AfterAuthentication - checks the request to see if the current user is authenticated and outputs its results to the console window

Below screen grab highlights in particular the output from the AfterAuthentication middleware before and after a user is registered.

![image](https://github.com/RedCamel69/ASP.NET-Core-Middleware/assets/10982602/057aa41d-53a8-434a-a33b-5589a460c8e4)

![image](https://github.com/RedCamel69/ASP.NET-Core-Middleware/assets/10982602/f11a5e4c-f8af-4aa3-8a9d-bbca7ac667af)


