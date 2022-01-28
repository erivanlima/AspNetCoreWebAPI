using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {

        public ProfessorController() { }

        [HttpGet]
        public IActionResult Get() 
        {
                return Ok("Professor: Maria, Paula, Lucas, Rafa");
        }

        [HttpPost]
        public IActionResult Post(Professor professor) 
        {
            return Ok(professor);
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor) 
        {
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor) 
        {
            return Ok(professor);
        }
        
    }
}