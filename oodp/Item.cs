using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodp
{
    public interface Item
    {
        void add(Item item);
        void remove(Item item);
        //   	public List<Item> getProducts();
        //		public String getName();
        //		public double getPrice();
        //		public int getQuantity();
        //	    List<Observer> observers=new ArrayList<Observer>();
    }
}
