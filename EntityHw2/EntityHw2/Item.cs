using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHw2
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
