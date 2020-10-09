using System.Collections.Generic;

namespace Yelp.Models
{
  public class Port
  {
    public Port()
    {
      this.Vessels = new HashSet<Vessel>();
    }

    public int PortId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Vessel> Vessels { get; set; }
  }
}