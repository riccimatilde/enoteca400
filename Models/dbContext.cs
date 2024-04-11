using Microsoft.EntityFrameworkCore;

public class dbContext : DbContext
{

    public DbSet<Registrazione> Registrazioni { get; set; }
    public DbSet<Carrello> Carrelli { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=dbECommerce.db");

    public dbContext(DbContextOptions<dbContext> options) : base(options) { }
}

