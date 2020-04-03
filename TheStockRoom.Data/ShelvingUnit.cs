using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Data
{
    public class ShelvingUnit
    {
        [Key]
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int NumberOfShelves { get; set; }
        public int DefaultRowsPerShelf { get; set; } //ignore if organizing with deminsions
        public int DefaultColumnsPerShelf { get; set; } //ignore if organizing with deminsions
        public double DefaultShelfHeight { get; set; }
        public double DefaultShelfWidth { get; set; }
        public virtual ICollection<Shelf>Shelves { get; set; }
    }
}
