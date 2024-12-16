//
// Modelo Book (Livro)
//
// TODO: Adicione uma propriedade de chave primária Id (ex.: int Id)

// TODO: Adicione uma propriedade obrigatória Titulo (ex.: string Titulo)
// Adicione uma restrição de comprimento, se necessário.

// TODO: Adicione uma propriedade obrigatória DataDePublicacao (DateTime)

// TODO: Adicione uma chave estrangeira AuthorId (ex.: int AuthorId)

// TODO: Adicione uma propriedade de navegação para Author

// Pontos a ser avaliados
//  01 : Implementar com as melhores práticas os atributos requisitados;
//  02 : Seguir as melhores práticas do (EF Core) Entity Framework Core com *annotations* se necessário;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp.Models
{
    public class Book
    {
    }
}
