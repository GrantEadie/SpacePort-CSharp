namespace SpacePort.Models
{
  public class Manifest
  {
    public int ManifestId { get; set; }
    public string Description { get; set; }
    public string UserName { get; set; }
    public string UserImage { get; set; }
    public int VesselId { get; set; }
    public virtual Vessel Vessel { get; set; }
  }
}