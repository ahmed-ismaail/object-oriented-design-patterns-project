using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodp
{
    class category : Item
    {
        private String name;
        private List<Item> products = new List<Item>();
        
        public void add(Item item)
        {
            products.Add(item);
        }
        
        public void remove(Item item)
        {
            products.Remove(item);
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
    }
}
