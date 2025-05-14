using TestApp.Domain.Models;

namespace TestApp.Domain.Interfaces;

public interface IAuthorRepository
{
  public Task<IEnumerable<Author>> GetAllAsync();

  public Task<Author?> GetByIdAsync(Guid id);

  public Task<Author?> AddAsync(Author author);

  public Task Update(Author author);

  public Task Delete(Author author);
}
