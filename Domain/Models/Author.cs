namespace TestApp.Domain.Models
{
  public class Author
  {
    public Guid Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public DateTime DataDeNascimento { get; set; }

    /* public List<Book>? Books { get; set; } = null; */
  }
}
