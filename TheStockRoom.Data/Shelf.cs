using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Data
{
    public class Shelf
    {
        [Key]
        public int ShelfId { get; set; }
        public double AdjustHeight { get; set; }
        public double AdjustWidth { get; set; }
        public int AdjustColumnNumber { get; set; }
        public int AdjustRowNumber { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public int ShelvingUnitId { get; set; }
        [ForeignKey("ShelvingUnitId")]
        public virtual ShelvingUnit Unit { get; set; }
    }
}

