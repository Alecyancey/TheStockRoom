using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Data
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string PrimaryCharacteristic { get; set; }
        public string SecondaryCharacteristic { get; set; }
        public double Size { get; set; }
        public decimal Price { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public int ShelvedItemId { get; set; }
        [ForeignKey("ShelvedItemId")]
        public virtual ShelvedItem ItemLocation { get; set; }

    }
}
