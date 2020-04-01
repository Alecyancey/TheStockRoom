using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Models
{
    public class ItemCreate
    {
        public string PrimaryCharacteristic { get; set; }
        public string SecondaryCharacteristic { get; set; }
        public double Size { get; set; }
        public decimal Price { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
