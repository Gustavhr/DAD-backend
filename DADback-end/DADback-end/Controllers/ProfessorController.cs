using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DADback_end.Model;
using DADback_end.Services;
using DADback_end.Services.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace DADback_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private IProfessorService _professorService;


        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;

        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_professorService.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var professor = _professorService.Findbyid(id);
                if (professor == null) return NotFound();
            return Ok(professor);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Professor professor)
        {

            if (professor == null) return BadRequest();
            return new ObjectResult(_professorService.Create(professor));
        }

        public IActionResult Post([FromBody] List<Professor> professor)
        {

            if (professor == null) return BadRequest();
            return new ObjectResult(_professorService.Create(professor));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Professor professor)
        {
            if (professor == null) return BadRequest();
            return new ObjectResult(_professorService.Update(professor));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _professorService.Delete(id);
            return NoContent();

        }
    }
}
