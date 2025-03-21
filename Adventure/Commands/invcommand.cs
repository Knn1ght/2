using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class invcommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.WriteLine("[green] ------------------------------- [/]");
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine($"Your current items are {string.Join(", ", world.Inventory.ItemsInv)}");
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("[green] ------------------------------- [/]");           
        }
    }
}
