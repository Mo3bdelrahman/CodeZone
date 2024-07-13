using CodeZone.Application.Exceptions;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace CodeZone.Application.Middlewares
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptions(context, ex);
            }
        }
        private async Task HandleExceptions(HttpContext httpContext, Exception exception)
        {
            HttpStatusCode statusCode;
            string message;
            switch (exception)
            {
                case BadRequestException:
                    statusCode = HttpStatusCode.BadRequest;
                    message = exception.Message;
                    break;
                case NotFoundException:
                    statusCode = HttpStatusCode.NotFound;
                    message = exception.Message;
                    break;
                default:
                    statusCode = HttpStatusCode.InternalServerError;
                    message = "internal servel error";
                    break;
            }

            httpContext.Response.StatusCode = (int)statusCode;
            httpContext.Items["errorMessage"] = message;
            httpContext.Response.Redirect("/Home/Error");
            await Task.CompletedTask;

        }

    }
}
