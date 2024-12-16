using TestApp.Models;
using TestApp.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("api/author")]
    public class AuthorController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        public AuthorController(LibraryDbContext context)
        {
            _context = context;
        }

        // Exemplo implementado: listar todos os autores com todos os seus livros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthorsWithBooks()
        {
            // TODO: Buscar autores no banco, incluindo os livros relacionados
            /* return Ok(await _context.Authors.Include(a => a.Books).ToListAsync()); */
        }

        // TODO: Implementar método POST /api/author para criar um novo Autor

        // TODO: (Extra) Implementar PUT /api/author/{id} para atualizar um Autor

        // TODO: (Extra) Implementar DELETE /api/author/{id} para deletar um Autor
    }
}
