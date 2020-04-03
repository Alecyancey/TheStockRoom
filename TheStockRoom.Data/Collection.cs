using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Data
{
    public class Collection
    {
        [Key]
        public int CollectionId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<CollectionItem> CollectionItems { get; set; }
    }
}
