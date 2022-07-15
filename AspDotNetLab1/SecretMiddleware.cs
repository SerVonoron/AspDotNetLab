using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetLabs1
{
    public class SecretMiddleware
    {
        private readonly RequestDelegate _next;

        public SecretMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if (path == "/secret-571743235872348")
            {
                await context.Response.WriteAsync("Hello it's a Secret Page");
            }
            else
            { 
            await _next.Invoke(context);
            }
        }
    }
}
