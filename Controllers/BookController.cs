// TODO: Implementar com êxito um CRUD do Autor com os métodos

//    01   : Create (criar novo Autor)
//    02   : Read (listar todos os Autores)
// (Extra) : Update (sobescrever Autor específico)
// (Extra) : Delete (deletar Autor específico)


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
        private readonly LibraryDbContext _context;

        public BookController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
        }

        [HttpPost]
        public async Task<ActionResult<Book>> CreateBook(Book book)
        {
        }
    }
}

