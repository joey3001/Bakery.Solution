using System.Collections.Generic;

namespace Bakery.Models
{
  public class TreatFlavor
  {
    public int TreatFlavorId { get; set; }
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public Flavor Flavor { get; set; } 
    public Treat Treat { get; set; } 
  }
}