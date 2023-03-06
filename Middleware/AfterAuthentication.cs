namespace ASP.Net_Core_Middleware.Middleware
{
    public class AfterAuthentication
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AfterAuthentication> _logger;

        public AfterAuthentication(RequestDelegate next, ILogger<AfterAuthentication> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation("ILogger LogInformation from AfterAuthentication.");

            if (context.User.Identity.IsAuthenticated)
            {
                _logger.LogInformation("User Authenticated.");
            }
            else
            {
                _logger.LogInformation("User not authenticated");
            }

            await _next(context);
        }
    }
}
