using Microsoft.EntityFrameworkCore;
using REST_API.Models;

namespace REST_API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieTheater> MovieTheaters { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Address>()
            .HasOne(address => address.MovieTheater)
            .WithOne(movieTheater => movieTheater.Address)
            .HasForeignKey<MovieTheater>("AddressForeignKey");
    }

    // Connection string configuration
    protected override void OnConfiguring(DbContextOptionsBuilder opt) => opt.UseMySql(
        connectionString: "Server=localhost;Port=3306;Database=movieDB;Uid=lcsef;Pwd=258456",
        serverVersion: ServerVersion.Parse("8.0.28-mysql"));
}
