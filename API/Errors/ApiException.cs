namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string message = null, string detailes = null) : base(statusCode, message)
        {
            Details = detailes;
        }

        public string Details { get; set; }
    }
}