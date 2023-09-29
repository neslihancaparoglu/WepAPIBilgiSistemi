using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uygulama1.Models;

namespace Uygulama1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Lesson : ControllerBase
    {
        private readonly AppContext _appContext;
        public Lesson(AppContext context)
        {
           _appContext = context;   
            
        }
        [HttpPost("add-student")]
        public IActionResult AddStudent(Student student ) //  başarılı-başarısız olayı. 
        {
           StudentBusinessCode studentBusinessCode = new StudentBusinessCode(_appContext);
            studentBusinessCode.AddStudent(student);
            return Ok();
        }

        [HttpDelete("delete-student")]
        public IActionResult DeleteStudent(string fullName )
        {
            StudentBusinessCode studentBusinessCode =new StudentBusinessCode( _appContext);
            studentBusinessCode.DeleteStudent( fullName);
                
            return Ok();                    
        }
        [HttpPut("update-student")]
        public IActionResult GetStudent(Student  update)
        {
            StudentBusinessCode studentBusinessCode= new StudentBusinessCode( _appContext);
            studentBusinessCode.UpdateStudent(update);
            return Ok();
        }
        [HttpGet("get-student")]
        public IActionResult GetStudent(string fullName)
        {
            StudentBusinessCode studentBusinessCode =  new StudentBusinessCode(_appContext);
            Student student=studentBusinessCode.GetStudent(fullName );   
            return Ok(student);

        }

    }
}
