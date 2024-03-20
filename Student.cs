using System.Text.Json.Serialization;

namespace StudentsApi.Models
{

    public enum Genders
    {
        [JsonPropertyName("זכר")] 
        Male = 0,
        [JsonPropertyName("נקבה")]
        Femail = 1,
        [JsonPropertyName("ללא")]
        None = 2,
    }

    public enum StudentStatuses
    {
        [JsonPropertyName("חדש")]
        New = 0,
        [JsonPropertyName("ממשיך")]
        InProcess = 1,
        [JsonPropertyName("סיים")]
        Finished = 2,
    }

    public enum StudentTypes
    {
        [JsonPropertyName("מנהלה")]
        InHouse = 0,
        [JsonPropertyName("חיצוני")]
        External = 1,
       
    }

    public class StudentApiModel
    {
        [JsonPropertyName("idnumber")]
        public string IdNumber { get; set; }
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }
        [JsonPropertyName("birthdate")]
        public DateTime BirthDate { get; set; }
        [JsonPropertyName("countryoforigin")]
        public string CountryOfOrigin { get; set; }
        [JsonPropertyName("gender")]     
        public string Gender { get; set; }
        [JsonPropertyName("studentclass")]
        public string StudentClass { get; set; }
        [JsonPropertyName("studentstatus")]
        public string StudentStatus { get; set; }
        [JsonPropertyName("studenttype")]
        public string StudentType { get; set; }

        public Genders genders { get; set; }
    }
}
