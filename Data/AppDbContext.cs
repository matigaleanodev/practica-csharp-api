using Microsoft.EntityFrameworkCore;
using PracticaApiEfMysql.Models;

namespace PracticaApiEfMysql.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

  public DbSet<Post> Posts => Set<Post>();
}
