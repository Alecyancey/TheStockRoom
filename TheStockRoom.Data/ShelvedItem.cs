using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Data
{
    public class ShelvedItem
    {
        [Key]
        public int ShelvedItemId { get; set; }
        public int ShelfId { get; set; }
        [ForeignKey("ShelfId")]
        public virtual Shelf Shelf { get; set; }
        public int ItemId { get; set; }
        [ForeignKey("ShelfId")]
        public virtual Item Item { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
    }
}
