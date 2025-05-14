namespace TestApp.Domain.Models
{
  public class Book
  {
    public Guid Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public DateTime DataDePublicacao { get; set; }

    public Guid AuthorId { get; set; }

    public Author Author { get; set; } = null!;
  }
}
