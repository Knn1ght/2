using Adventure.Items;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class HealthBar
    {
        public int Healthbar { get; }
        public int HealthBarFunc { get; private set; } = 100;

        public void ReduceHealth(int health)
        {
            HealthBarFunc -= health;
        }

    }
}
