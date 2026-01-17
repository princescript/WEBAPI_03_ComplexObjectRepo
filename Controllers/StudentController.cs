using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI03_ComplexObjectRepo.Model;

namespace WEBAPI03_ComplexObjectRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetData()
        {
            
            return Repository.students;
        }
    }
}
