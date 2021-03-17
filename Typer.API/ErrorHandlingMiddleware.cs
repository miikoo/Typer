using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using Typer.Domain.Exceptions;

namespace Typer.API
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var httpStatusCode = HttpStatusCode.InternalServerError; // 500 if unexpected

            var exceptionType = exception.GetType();
            switch (exception)
            {
                case Exception _ when exceptionType == typeof(TyperBadRequestException):
                    httpStatusCode = HttpStatusCode.BadRequest;
                    break;
                case Exception _ when exceptionType == typeof(TyperUnauthorizedException):
                    httpStatusCode = HttpStatusCode.Unauthorized;
                    break;
            }
            
            var result = JsonConvert.SerializeObject(new { error = exception.Message });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)httpStatusCode;
            return context.Response.WriteAsync(result);
        }
    }
}
//     case TyperBadRequestException:
//httpStatusCode = HttpStatusCode.BadRequest;
//break;
//                case TyperUnauthorizedException:
//httpStatusCode = HttpStatusCode.Unauthorized;
//break;
