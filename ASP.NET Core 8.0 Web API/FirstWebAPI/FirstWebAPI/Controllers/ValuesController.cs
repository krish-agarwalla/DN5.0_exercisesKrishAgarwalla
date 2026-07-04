using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string>()
        {
            "Apple",
            "Banana",
            "Orange"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest("Invalid Id");

            return Ok(values[id]);
        }

        [HttpPost]
        public IActionResult Post(string value)
        {
            values.Add(value);
            return Ok("Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, string value)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest("Invalid Id");

            values[id] = value;
            return Ok("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
                return BadRequest("Invalid Id");

            values.RemoveAt(id);
            return Ok("Deleted Successfully");
        }
    }
}