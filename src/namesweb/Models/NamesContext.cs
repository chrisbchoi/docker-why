using Microsoft.EntityFrameworkCore;

namespace namesweb.Models
{
public class NamesContext : DbContext
{
  public NamesContext(DbContextOptions<NamesContext> options) : base(options)
  {
  }

  public DbSet<Name> Names { get; set; }
  }
}