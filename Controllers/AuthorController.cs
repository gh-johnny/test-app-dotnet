using TestApp.Infra;
using TestApp.Domain.Models;
using TestApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
  [ApiController]
  [Route("api/author")]
  public class AuthorController : ControllerBase
  {
    private readonly TestAppDbContext _context;
    private readonly IAuthorRepository _authorRepository;

    public AuthorController(
        TestAppDbContext context,
        IAuthorRepository authorRepository)
    {
      _context = context;
      _authorRepository = authorRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
    {
      var authors = await _authorRepository.GetAllAsync();
      return Ok(authors.ToList());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Author>> GetAuthorById(string id)
    {
      if (!Guid.TryParse(id, out Guid validId))
        return BadRequest("Id inválido");

      var author = await _authorRepository.GetByIdAsync(validId);
      if (author is null)
        return NotFound("Não foi possível encontrar Autor");

      return author;
    }

    [HttpPost]
    public async Task<ActionResult> CreateAuthor(Author author)
    {
      var createdAuthor = await _authorRepository.AddAsync(author);
      return CreatedAtAction(nameof(GetAuthorById), new { id = createdAuthor!.Id }, author);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateAuthor(Author author)
    {
      await _authorRepository.Update(author);
      return Ok("Autor editado com sucesso");
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteAuthor(string id)
    {
      if (!Guid.TryParse(id, out Guid validId))
        return BadRequest("Id inválido");

      var author = await _authorRepository.GetByIdAsync(validId);
      if (author is null)
        return NotFound("Não foi possível encontrar Autor");

      await _authorRepository.Delete(author);
      return Ok("Autor deletado com sucesso");
    }
  }
}
