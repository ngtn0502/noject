using Noject.Application.Common.Errors;
using System.Net;
using System.Text.Json;

namespace Noject.API.Middleware
{
    public class GlobalExceptionHandler
    {
        public async Task InvokeAsync(HttpContext httpContext, Func<Task> next)
        {
			try
			{
                await next();
			}
			catch (Exception ex)
			{
                Exception? _ = ex switch
                {
                    NojectException => throw new NojectException("Internal server error", HttpStatusCode.BadRequest),
                    _ => null
                };
                await HandleException(httpContext, ex);
			}
        }

        private static Task HandleException(HttpContext context, Exception ex)
        {
            var code = HttpStatusCode.InternalServerError;
            var message = JsonSerializer.Serialize(new { message = ex.Message } );

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(message);
        }
    }
}
