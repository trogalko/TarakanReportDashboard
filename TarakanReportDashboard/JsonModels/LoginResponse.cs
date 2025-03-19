using System.Text.Json.Serialization;

namespace TarakanReportDashboard.JsonModels.LoginResponse
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Metadata
    {
        [JsonPropertyName("message")]
        public string message { get; set; }

        [JsonPropertyName("code")]
        public int code { get; set; }
    }

    public class Response
    {
        [JsonPropertyName("userID")]
        public string userID { get; set; }

        [JsonPropertyName("userName")]
        public string userName { get; set; }

        [JsonPropertyName("srLanguage")]
        public string srLanguage { get; set; }

        [JsonPropertyName("isLocked")]
        public bool isLocked { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("response")]
        public Response response { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata metadata { get; set; }
    }


}
