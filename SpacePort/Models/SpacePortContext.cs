using Microsoft.EntityFrameworkCore;

namespace Yelp.Models
{
  public class YelpContext : DbContext
  {
    public virtual DbSet<Port> Ports { get; set; }
    public virtual DbSet<Vessel> Vessels { get; set; }

    public virtual DbSet<Manifest> Manifests { get; set; }

    public YelpContext(DbContextOptions options) : base(options) { }
  }
}