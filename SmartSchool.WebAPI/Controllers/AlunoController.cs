using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
            Id = 1,
            Nome = "Marcos",
            Sobrenome = "Silva",
            Telefone = "4654646"
            },
            new Aluno(){
            Id = 2,
            Nome = "Maria",
            Sobrenome = "Jose",
            Telefone = "997979"
            },
             new Aluno(){
            Id = 3,
            Nome = "João",
            Sobrenome = "Gustavo",
            Telefone = "1154545"
            },
        };

        public AlunoController() { }

        [HttpGet]
        public IActionResult Get() 
        {
                return Ok(Alunos);
        }

        // api/aluno/byId
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id) 
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if(aluno == null) return BadRequest("Aluno não encontrado!!");

            return Ok(aluno);
        }


        // api/aluno/nome
        [HttpGet("ByName")]
        public IActionResult GetByName(string nome, string Sobrenome) 
        {
            var aluno = Alunos.FirstOrDefault(a => 
            a.Nome.Contains(nome) && a.Sobrenome.Contains(Sobrenome));
            if(aluno == null) return BadRequest("Aluno não encontrado!!!");

            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno) 
        {
            return Ok(aluno);
        }
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno) 
        {
            return Ok(aluno);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno) 
        {
            return Ok(aluno);
        }
        
    }
}