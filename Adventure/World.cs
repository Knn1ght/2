﻿using Adventure.Items;
using Adventure.Rooms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class World
    {
        public BaseRoom CurrentRoom { get; private set; }
        public void SwitchRoom(BaseRoom room)
        {
            CurrentRoom = room;
        }

        public World()
        {
            var lobby = new Lobby();
            var corridor = new Corridor();

            lobby.RegisterNeighbour(corridor);
            corridor.RegisterNeighbour(lobby);

            CurrentRoom = lobby;
        }
        public Inventory Inventory { get; } = new();
        public HealthBar HealthBar { get; } = new();
        public string Intro { get; } = @"
How did you end up here? You don't really know. Maybe you fell, maybe someone pushed you.
One thing is certain, you need to [red italic]GET OUT OF HERE![/]
";
    }
}
