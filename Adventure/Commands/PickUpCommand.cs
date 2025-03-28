using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class PickUpCommand : BaseCommand
    {
        private Random rnd = new Random();

        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.MarkupLine($"What do you want to pick up? {string.Join(",", world.CurrentRoom.Items)}");
                return;
            }

            var random = rnd.Next();
            if (random == 0)
            {
                AnsiConsole.WriteLine("You slipped off the floor, while trying to pick an item");
                world.HealthBar.ReduceHealth(20);
                return;
            }   
            var item = world.CurrentRoom.Items.FirstOrDefault(n => n.Name == @params[0]);
            if (item == null)
            {
                AnsiConsole.WriteLine($"[red]Wrong item[/]");
                return;

            }
            world.Inventory.ItemsInv.Add(item);
        }
    }
}
