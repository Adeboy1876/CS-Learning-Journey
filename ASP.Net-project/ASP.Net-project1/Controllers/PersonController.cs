using ASP.Net_project1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP.Net_project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private static List<Person> persons = new List<Person>();

        [HttpGet]
        public IActionResult GetAllPersons()
        {
            return Ok(persons);
        }

        [HttpPost]
        public IActionResult AddPerson([FromBody] Person person)
        {
            if (person == null)
            {
                return BadRequest("Person data is invalid");
            }
            person.Id = persons.Count + 1;
            persons.Add(person);
            return CreatedAtAction(nameof(GetAllPersons), new { id = persons.Count - 1 },
                person);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePerson(int id, [FromBody] Person updatedperson) 
        {
            var person = persons.FirstOrDefault(p => p.Id==id);

            if(person == null) return NotFound();

            person.Name = updatedperson.Name;
            person.Age = updatedperson.Age;
            person.Email = updatedperson.Email;

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id) 
        {
            var person = persons.FirstOrDefault(p => p.Id == id);
            if(person == null) return NotFound();

            persons.Remove(person);
            return NoContent();
        }

    }
}
