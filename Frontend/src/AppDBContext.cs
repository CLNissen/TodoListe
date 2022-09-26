using Microsoft.EntityFrameworkCore;

namespace TodoListe.DB {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}