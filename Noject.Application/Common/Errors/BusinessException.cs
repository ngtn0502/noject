using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Noject.Application.Common.Errors
{
    public class NojectException : Exception
    {
        public NojectException(string? message, HttpStatusCode statusCode) : base()
        {
            this.Message = message;
            this.StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }

        public string Message { get; set; }
    }
}
