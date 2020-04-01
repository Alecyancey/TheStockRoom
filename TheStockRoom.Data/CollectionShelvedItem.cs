using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Data
{
    public class CollectionShelvedItem
    {
        [Key]
        public int CollectionShelvedItemId { get; set; }
        public int CollectionId { get; set; }
        [ForeignKey("CollectionId")]
        public virtual Collection Collection { get; set; }
        public int ShelvedItemId { get; set; }
        [ForeignKey("ShelvedItemId")]
        public virtual ShelvedItem ShelvedItem { get; set; }

    }
}
