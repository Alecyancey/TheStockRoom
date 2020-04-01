using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Data
{
    public class ItemLocation
    {
        [Key]
        public int ItemLocationId { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public int ShelfId { get; set; }
        [ForeignKey("ShelfId")]
        public virtual Shelf Shelf { get; set; }
    }
}
