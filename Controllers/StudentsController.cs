using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using StudentsApi.Models;
using StudentsApi.Dal;
using StudentsApi.Api;

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

        [HttpGet(Name = "getstudents")]
        public IActionResult  getstudents(string filterbyfirstname = "")
        {
            ApiResponse<IEnumerable<StudentApiModel>> response = new ApiResponse<IEnumerable<StudentApiModel>> { };
            try
            {
                StudentsDal dal = new StudentsDal(_config);
                response.Data = dal.GetStudents();
            }
            catch (Exception  e)
            {
                response.Success = false;
                response.ErrorMessage = $"getstudents error: {e.Message}";
            }

            return Ok(response);
                  
        }

        [HttpGet(Name = "GetStudentsAsync")]
        public async Task<IActionResult> GetStudentsAsync()
        {
            ApiResponse<IEnumerable<StudentApiModel>> response = new ApiResponse<IEnumerable<StudentApiModel>>();
            try
            {
                StudentsDal dal = new StudentsDal(_config);
                response.Data = await dal.GetStudentsAsync();
            }
            catch (Exception e)
            {
                response.Success = false;
                response.ErrorMessage = $"GetStudents Error: {e.Message}";
            }

            return Ok(response);
        }

    }
}
