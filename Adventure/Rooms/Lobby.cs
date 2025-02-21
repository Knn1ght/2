using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Lobby : BaseRoom
    {
        public Lobby()
        {
            AddItem(new Sword());
        }
           
        public override string Description => "Starting room";

        public override string Name => "Lobby";
    }
}
