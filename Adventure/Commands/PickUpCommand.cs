using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class PickUpCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.MarkupLine($"What do you want to pick up? {string.Join(",", world.CurrentRoom.Items)}");
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
