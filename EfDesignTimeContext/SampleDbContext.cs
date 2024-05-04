using Microsoft.EntityFrameworkCore;

namespace EfDesignTimeContext;

public class SampleDbContext : DbContext
{
    public SampleDbContext(DbContextOptions<SampleDbContext> options)
        : base(options) { }

    public SampleDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=SampleFromOnConfiguring;Integrated Security=True"
            );
        }
    }

    public DbSet<Person> Persons { get; set; }
}
