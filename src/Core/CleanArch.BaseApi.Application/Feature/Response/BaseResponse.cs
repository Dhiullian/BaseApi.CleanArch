using System.Collections.Generic;

namespace CleanArch.BaseApi.Application.Feature.Response
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> ValidationErrors { get; set; }

        public BaseResponse()
        {
            Success = true;
        }
        public BaseResponse(string message = "")
        {
            Success = true;
            Message = message;
        }

        public BaseResponse(bool success, string message = "" )
        {
            Success = success;
            Message = message;
            ValidationErrors = new List<string>();
        }
    }
}
