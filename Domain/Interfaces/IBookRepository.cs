using TestApp.Domain.Models;

namespace TestApp.Domain.Interfaces;

public interface IBookRepository
{
  public Task<IEnumerable<Book>> GetAllAsync();

  public Task<Book?> GetByIdAsync(Guid id);

  public Task<Book?> AddAsync(Book author);

  public Task Update(Book author);

  public Task Delete(Book author);
}
