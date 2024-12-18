using TestApp.Infra;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    [ApiController]
    [Route("api/author")]
    public class AuthorController : ControllerBase
    {
        private readonly TestAppDbContext _context;

        public AuthorController(TestAppDbContext context)
        {
            _context = context;
        }

        // TODO: Implementar método GET /api/author para buscar autores no banco

        // TODO: Implementar método GET /api/author/{id} para buscar autor no banco com livros relacionados

        // TODO: Implementar método POST /api/author para criar um novo Autor

        // TODO: (Extra) Implementar PUT /api/author/{id} para atualizar um Autor

        // TODO: (Extra) Implementar DELETE /api/author/{id} para deletar um Autor
    }
}
