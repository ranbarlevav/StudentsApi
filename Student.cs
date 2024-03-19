using System.Text.Json.Serialization;

namespace StudentList.Server
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

    public class Student
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
        public Genders Gender { get; set; }
        [JsonPropertyName("studentclass")]
        public string StudentClass { get; set; }
        [JsonPropertyName("studentstatus")]
        public string StudentStatus { get; set; }
        [JsonPropertyName("studenttype")]
        public string StudentType { get; set; }
    }
}
