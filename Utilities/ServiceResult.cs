using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class ServiceResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public static ServiceResult SuccessResult(string message = "Success",
            HttpStatusCode statusCode = HttpStatusCode.OK) =>
            new() { Success = true, Message = message, StatusCode = statusCode };

        public static ServiceResult FailureResult(string message = "An error occurred.", 
            HttpStatusCode statusCode = HttpStatusCode.BadRequest) =>
            new() { Success = false, Message = message, StatusCode = statusCode };
    }

    public class ServiceResult<T> : ServiceResult
    {
        public T? Data { get; set; }

        public static ServiceResult<T> SuccessResult(T data, string message = "Success",
            HttpStatusCode statusCode = HttpStatusCode.OK) =>
            new ()
            {
                Success = true,
                Message = message,
                StatusCode = statusCode,
                Data = data
            };

        public static ServiceResult<T> FailureResult(string message = "An error occurred.",
            HttpStatusCode statusCode = HttpStatusCode.BadRequest) =>
            new ()
            {
                Success = false,
                Message = message,
                StatusCode = statusCode,
                Data = default
            };
    }
}
