using StudentsApi.Models;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace StudentsApi.Dal
{
    public class StudentsDal
    {
        public int MyProperty { get; set; }
        private readonly IConfiguration _config;
        public StudentsDal(IConfiguration config)
        {
            _config = config;
        }

        public string GovConnectionString
        {
            get
            {
                return Convert.ToString(_config["Data:DefaultConnection:ConnectionString"]);
            }
        }

        public IEnumerable<StudentApiModel> GetStudents()
        {
            List<StudentApiModel> students = new List<StudentApiModel>();
            using (SqlConnection connection =
                       new SqlConnection(GovConnectionString))
            {
                SqlCommand command =
                    new SqlCommand("GetStudents", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    StudentApiModel student = new StudentApiModel();
                    student.IdNumber = reader.GetString("id_number");
                    student.FirstName = reader.GetString("first_name");
                    student.LastName = reader.GetString("last_name");
                    student.BirthDate = reader.GetDateTime("birth_date");
                    student.CountryOfOrigin = reader.GetString("countryoforigin");
                    student.Gender = reader.GetString("gender_name");
                    student.StudentClass = reader.GetString("class");
                    student.StudentStatus = reader.GetString("student_status_name");
                    student.StudentType = reader.GetString("student_type_name");

                    students.Add(student);
                }

                // Call Close when done reading.
                reader.Close();
            }
            return students;
        }

        public async Task<IEnumerable<StudentApiModel>> GetStudentsAsync()
        {
            List<StudentApiModel> students = new List<StudentApiModel>();
            using (SqlConnection connection =
                       new SqlConnection(GovConnectionString))
            {
                SqlCommand command =
                    new SqlCommand("GetStudents", connection);
                connection.Open();

                SqlDataReader reader = await command.ExecuteReaderAsync();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    StudentApiModel student = new StudentApiModel();
                    student.IdNumber = reader.GetString("id_number");
                    student.FirstName = reader.GetString("first_name");
                    student.LastName = reader.GetString("last_name");
                    student.BirthDate = reader.GetDateTime("birth_date");
                    student.CountryOfOrigin = reader.GetString("countryoforigin");
                    student.Gender = reader.GetString("gender_name");
                    student.StudentClass = reader.GetString("class");
                    student.StudentStatus = reader.GetString("student_status_name");
                    student.StudentType = reader.GetString("student_type_name");

                    students.Add(student);
                }

                // Call Close when done reading.
                reader.Close();
            }
            return students;
        }

    }
}

