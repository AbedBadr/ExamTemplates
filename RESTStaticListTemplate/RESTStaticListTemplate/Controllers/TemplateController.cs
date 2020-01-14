using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTStaticListTemplate.Model;

namespace RESTStaticListTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        static List<ClassTemplate> tList = new List<ClassTemplate>()
        {
            new ClassTemplate(1, "Test"),
            new ClassTemplate(2, "Test2")
        };

        // GET: api/Template
        [HttpGet]
        [Route("/api/Template")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Template/5
        [HttpGet]
        [Route("/api/Template/{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Template
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Template/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
