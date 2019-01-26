using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityHw2
{
    public class Cart
    {
        public Guid Id { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
