﻿
using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);  // ?? means "if this is null execute what to the right after question marks"
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request",
                401 => "You Are Not Authorized",
                404 => "Resource not found",
                500 => "Server error",
                _ => null  //default case
            };
        }
    }
}
