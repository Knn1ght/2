using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public abstract class BaseRoom
    {
        public List<BaseRoom> Neighbours = new List<BaseRoom>();
        public List<BaseItem> Items = new List<BaseItem>();

        public abstract string Name { get; }
        public abstract string Description { get; }

        public void RegisterNeighbour(BaseRoom room)
        {
            Neighbours.Add(room);
        }

        public void AddItem(BaseItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(BaseItem item) 
        { 
            Items.Remove(item); 
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
