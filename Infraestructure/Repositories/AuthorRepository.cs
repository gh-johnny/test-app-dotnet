using TestApp.Domain.Models;
using TestApp.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Infra.Repository
{
  public class AuthorRepository : IAuthorRepository
  {
    private readonly TestAppDbContext _context;

    public AuthorRepository(TestAppDbContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<Author>> GetAllAsync()
    {
      return await _context.Authors
        .ToListAsync();
    }

    public async Task<Author?> GetByIdAsync(Guid id)
    {
      return await _context.Authors
        .FindAsync(id);
    }

    public async Task<Author?> AddAsync(Author author)
    {
      var createdAuthor = await _context.Authors
        .AddAsync(author);
      await _context.SaveChangesAsync();
      return createdAuthor.Entity;
    }

    public async Task Update(Author author)
    {
      var updatedAuthor = _context.Authors
        .Update(author);
      await _context.SaveChangesAsync();
    }

    public async Task Delete(Author author)
    {
      _context.Authors
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
