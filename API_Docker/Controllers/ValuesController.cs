using API_Docker.Models;
using API_Docker.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Docker.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ValuesController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("GET recebido!");
            return Ok(_context.Categories.ToList());
        }

        [HttpPost]
        public IActionResult Create(CategoryInput categoryInput)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var c = new Category()
            {
                Id = categoryInput.Id,
                Descricao = categoryInput.Descricao,
            };
            _context.Categories.Add(c);
            _context.SaveChanges();
            return Ok(categoryInput);
        }
    }
}
