using Microsoft.EntityFrameworkCore;
using REST_API.Models;

namespace REST_API.Data;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> opt) : base(opt)
    {

    }

    public DbSet<Movie> Movies { get; set; }

    // Connection string configuration
    protected override void OnConfiguring(DbContextOptionsBuilder opt) => opt.UseMySql(
        connectionString: "Server=localhost;Port=3306;Database=movieDB;Uid=lcsef;Pwd=258456",
        serverVersion: ServerVersion.Parse("8.0.28-mysql"));
}
