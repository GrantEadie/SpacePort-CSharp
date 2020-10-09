using Microsoft.EntityFrameworkCore;

namespace SpacePort.Models
{
  public class SpacePortContext : DbContext
  {
    public virtual DbSet<Port> Ports { get; set; }
    public virtual DbSet<Vessel> Vessels { get; set; }

    public virtual DbSet<Manifest> Manifests { get; set; }

    public SpacePortContext(DbContextOptions options) : base(options) { }
  }
}