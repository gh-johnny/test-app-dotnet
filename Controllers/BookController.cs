using TestApp.Infra;
using Microsoft.AspNetCore.Mvc;

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

        // TODO: Implementar POST /api/book para criar um novo Livro (com Autor existente)

        // TODO: Implementar GET /api/book/ para listar todos os livros (Com respectivo Autor (Id e Nome somente!))

        // TODO: Implementar PUT /api/book/{id} para atualizar um Livro existente.

        // TODO: Implementar DELETE /api/book/{id} para deletar um Livro.
    }
}
