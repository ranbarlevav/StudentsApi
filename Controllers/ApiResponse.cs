using System.Text.Json.Serialization;

namespace StudentsApi.Api
{
    public class ApiResponse<T>
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("data")]
        public T Data { get; set; }
        [JsonPropertyName("errormessage")]
        public string ErrorMessage { get; set; }

        public ApiResponse()
        {
            Success = true;
        }
    }
}
