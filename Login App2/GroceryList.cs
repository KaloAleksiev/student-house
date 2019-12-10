using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class GroceryList
    {
        List<Grocery> groceries;

        public GroceryList()
        {
            groceries = new List<Grocery>();
        }
        public void Add(Grocery grocery)
        {
            groceries.Add(grocery);
        }
        public List<Grocery> GetGroceries()
        {
            return groceries;
        }
        public Grocery GetGrocery(int index)
        {
            return groceries[index];
        }

    }
}
