using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SpacePort.Models
{
  public class Vessel
  {
    public Vessel()
    {
      this.Manifests = new HashSet<Manifest>();
    }
    public int VesselId { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Address { get; set; }
    public int PortId { get; set; }
    public virtual Port Port { get; set; }
    public virtual ICollection<Manifest> Manifests { get; set; }
  }
}
