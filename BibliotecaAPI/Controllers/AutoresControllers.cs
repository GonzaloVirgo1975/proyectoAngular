using BibliotecaAPI.Data;
using BibliotecaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly BibliotecaDbContext _context;

        public AutoresController(BibliotecaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Autor>>> GetAutores()
        {
            var autores = await _context.Autores.ToListAsync();

            return Ok(autores);
        }

        
    }
}