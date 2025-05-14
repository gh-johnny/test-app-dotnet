using TestApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

// ***** (Importante) ***********************************************************
// **                                                                          **
// *   Assuma que um livro pode conter apenas 1 autor e um autor vários livros  *
// **                                                                          **
// ***** (Importante) ***********************************************************
//
// OBS: Se as anotações EF nos modelos já estiverem corretas, este passo não é necessário

namespace TestApp.Infra
{
    public class TestAppDbContext : DbContext
    {
        public TestAppDbContext(DbContextOptions<TestAppDbContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Exemplos de algumas relações:

            // Um para Um (one-to-one)

            /* modelBuilder.Entity<User>() */
            /*   .HasOne(u => u.Address) */
            /*   .WithOne(a => a.User) */
            /*   .HasForeignKey(a => a.UserId) */
            /*   .OnDelete(DeleteBehavior.Cascade); */


            // Um para Muitos (one-to-many)

            /* modelBuilder.Entity<Blog>() */
            /*     .HasMany(b => b.Posts) */
            /*     .WithOne(p => p.Blog) */
            /*     .HasForeignKey(p => p.BlogId) */
            /*     .OnDelete(DeleteBehavior.Cascade); */


            // Muitos para Um (many-to-one)

            /* modelBuilder.Entity<Post>() */
            /*     .HasOne(p => p.Blog) */
            /*     .WithMany(b => b.Posts) */
            /*     .HasForeignKey(p => p.BlogId) */
            /*     .OnDelete(DeleteBehavior.Cascade); */


            // Muitos para Muitos (many-to-many)

            /* modelBuilder.Entity<Student>() */
            /*     .HasMany(s => s.Courses) */
            /*     .WithMany(c => c.Students) */
            /*     .UsingEntity(j => j.ToTable("StudentCourses")); */

            base.OnModelCreating(modelBuilder);
        }
    }
}
