namespace ASP.Net_Core_Middleware.Middleware
{
    public class LogLevelsMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LogLevelsMiddleware> _logger;

        public LogLevelsMiddleware(RequestDelegate next, 
            ILogger<LogLevelsMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {          
            _logger.LogTrace("ILogger LogTrace from ExampleMiddleware.");
            _logger.LogDebug("ILogger LogDebug from ExampleMiddleware.");
            _logger.LogInformation("ILogger LogInformation from ExampleMiddleware.");
            _logger.LogWarning("ILogger LogWarning from ExampleMiddleware.");
            _logger.LogError("ILogger LogError from ExampleMiddleware.");
            _logger.LogCritical("ILogger LogCritical from ExampleMiddleware.");

            await _next(context);
        }
    }
}
