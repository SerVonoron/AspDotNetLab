using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetLabs1
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UserLog
            (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggerMiddleware>();
        }

        public static IApplicationBuilder Secret
            (this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SecretMiddleware>();
        }
    }
}
