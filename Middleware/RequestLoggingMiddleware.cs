using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace UserManagementApi.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Store original response body stream
            var method = context.Request.Method;
            var path = context.Request.Path;

            await _next(context);

            var statusCode = context.Response.StatusCode;
            _logger.LogInformation("HTTP {Method} {Path} responded {StatusCode}", method, path, statusCode);
        }
    }
}