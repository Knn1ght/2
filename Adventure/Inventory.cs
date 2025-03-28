using Adventure.Items;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Inventory
    {
        public List<BaseItem> ItemsInv = new List<BaseItem>();
        public int Capacity => 20;

        public bool AddItem(BaseItem item)
        {
            if (ItemsInv.Sum(i => i.Weight) + item.Weight > Capacity)
            {
                AnsiConsole.WriteLine("You dont have any space in your invenory");
                return false;
            }

            ItemsInv.Add(item);
            return true;
        }
    }
    
}

