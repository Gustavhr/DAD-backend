using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DADback_end.Model;
using DADback_end.Services.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace DADback_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinasController : ControllerBase
    {
        private IDisciplinasService _disciplinaservice;


        public DisciplinasController(IDisciplinasService disciplinasService)
        {
            _disciplinaservice = disciplinasService;

        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_disciplinaservice.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var disciplina = _disciplinaservice.Findbyid(id);
                if (disciplina == null) return NotFound();
            return Ok(disciplina);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Disciplinas disciplina)
        {
          
            if (disciplina == null) return BadRequest();
            return new ObjectResult(_disciplinaservice.Create(disciplina));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Disciplinas disciplina)
        {
            if (disciplina == null) return BadRequest();
            return new ObjectResult(_disciplinaservice.Update(disciplina));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _disciplinaservice.Delete(id);
            return NoContent();

        }
    }
}
