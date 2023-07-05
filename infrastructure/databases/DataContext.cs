using System.Reflection;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

using entities;
using infrastructure.databases.seed;

namespace infrastructure.databases;

/// <summary>
/// Represents the main database context for your application.
/// </summary>
public class DataContext : DbContext
{
    /// <summary>
    /// Gets or sets the DbSet of countries in the database.
    /// </summary>
    /// <remarks>
    /// This property represents the collection of countries stored in the database.
    /// It allows querying and manipulating country data using LINQ and Entity Framework Core.
    /// </remarks>
    public DbSet<Country> Countries { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataContext"/> class.
    /// </summary>
    /// <param name="options">The options to be used for configuring the context.</param>
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    { }

    /// <summary>
    /// This method is called when the model for the database is being created.
    /// It is used to configure the model using the Fluent API or by convention-based configuration.
    /// </summary>
    /// <param name="modelBuilder">The builder being used to construct the model for the database.</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurations
        var assembly = typeof(DataContext).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);

        // modelBuilder.Entity<Country>().HasData(infrastructure.databases.seed.Countries.data);
    }
}
