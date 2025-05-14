using TestApp.Domain.Models;
using TestApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Infra.Repository
{
  public class BookRepository : IBookRepository
  {
    private readonly TestAppDbContext _context;

    public BookRepository(TestAppDbContext context)
    {
      _context = context;
    }

    // Aqui temos que trazer todos os livros juntamente com as informações do Autor daquele livro
    public async Task<IEnumerable<Book>> GetAllAsync()
    {
      throw new NotImplementedException();
    }

    public async Task<Book?> GetByIdAsync(Guid id)
    {
      return await _context.Books
        .FindAsync(id);
    }

    public async Task<Book?> AddAsync(Book author)
    {
      var createdBook = await _context.Books
        .AddAsync(author);
      await _context.SaveChangesAsync();
      return createdBook.Entity;
    }

    public async Task Update(Book author)
    {
      var updatedBook = _context.Books
        .Update(author);

      updatedBook.State = EntityState.Modified;

      await _context.SaveChangesAsync();
    }

    public async Task Delete(Book author)
    {
      _context.Books
        .Remove(author);
      await _context.SaveChangesAsync();
    }

    public async Task SaveChangesAsync()
    {
      await _context
        .SaveChangesAsync();
    }
  }
}
