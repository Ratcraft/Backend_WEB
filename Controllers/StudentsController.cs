using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentsController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students(){Id = 1, Age = 19, First_name = "Alexis", Last_name = "OOF"});
            students.Add(new Students(){Id = 2, Age = 20, First_name = "Lucas", Last_name = "BOUM BOUM"});
            students.Add(new Students(){Id = 3, Age = 19, First_name = "Louis", Last_name = "EL BG"});
            students.Add(new Students(){Id = 4, Age = 17, First_name = "Anjara", Last_name = "LE DOGITO"});
            students.Add(new Students(){Id = 5, Age = 19, First_name = "Tony", Last_name = "LA BAGARRE"});
            return students;
        }

        [HttpGet]
        public IEnumerable<Students> GetStudents_Lists()
        {
            return GetStudents();
        }

        [HttpGet("{id}")]
        public ActionResult<Students> GetStudents_ById(int id)
        {
            var students = GetStudents().Find(x => x.Id == id);
            if(students != null)
                return students;
            return NotFound();
        }
    }

    

}