using Microsoft.EntityFrameworkCore;


namespace TodoListDBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Todo>? Todos { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=tcp:todoliste.database.windows.net,1433;Initial Catalog=todoliste;Persist Security Info=False;User ID=CLNissen;Password=Fabian123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"
            );
        }*/
    }
}   

