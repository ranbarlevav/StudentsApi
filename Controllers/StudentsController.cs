using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using StudentsApi.Models;
using StudentsApi.Dal;

namespace StudentsApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IConfiguration _config;
        public StudentController( IConfiguration config)
        {
            _config = config;
        }

        [HttpGet(Name = "GetStudents")]
        public IEnumerable<StudentApiModel> GetStudents(string filterByFirstName = "")
        {
            StudentsDal dal = new StudentsDal(_config);
            return dal.GetStudents();
            //List<Student> res = new List<Student>();
            //for (int i = 1; i < 2000; i++)
            //{
            //    res.Add(new Student()
            //    {
            //        IdNumber = "034492181",
            //        FirstName = RandomString(5),
            //        LastName = RandomString(5),
            //        BirthDate = DateTime.Now.AddDays(1 * i),
            //        Gender = Genders.Male,
            //        StudentClass = "ז",
            //        StudentStatus = "לומד ממשיך",
            //        CountryOfOrigin = "ישראל",
            //        StudentType = "ממשיך"
            //    });
            //}


            //return res.ToArray();
        }

        public static string RandomString(int length)
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
