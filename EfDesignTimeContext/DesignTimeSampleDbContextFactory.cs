using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfDesignTimeContext;

public class DesignTimeSampleDbContextFactory : IDesignTimeDbContextFactory<SampleDbContext>
{
    public SampleDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SampleDbContext>();
        optionsBuilder.UseSqlServer(
            @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=SampleFromFactory;Integrated Security=True"
        );

        return new SampleDbContext(optionsBuilder.Options);
    }
}
