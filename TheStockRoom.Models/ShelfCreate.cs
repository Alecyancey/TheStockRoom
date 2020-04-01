using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStockRoom.Models
{
    public class ShelfCreate
    {
        public int SetRowMax { get; set; }
        public int SetColumnMax { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
