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
        public int SetRowNumber { get; set; }
        public int SetColumnNumber { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public virtual ICollection<ShelvedItem> Items { get; set; }
    }
}
