using TestApp.Models;
using TestApp.Infra;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly TestAppDbContext _context;

        public BookController(TestAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Author>>> GetAllBooks()
        {
            // TODO: Buscar livros no banco
            return Ok(await _context.Books.ToListAsync());
        }

        // TODO: Implementar POST /api/book para criar um novo Livro
        // Certifique-se de que o AuthorId exista no banco.

        // TODO: Implementar GET /api/book/{id} para listar todos os livros de 1 único Autor (já existente)

        // TODO: (Extra) Implementar PUT /api/book/{id} para atualizar um Livro existente.

        // TODO: (Extra) Implementar DELETE /api/book/{id} para deletar um Livro.
    }
}

