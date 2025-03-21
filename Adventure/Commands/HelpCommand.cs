using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class HelpCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.WriteLine("To interact with the game, use following commands ...");
            AnsiConsole.WriteLine("---");
            AnsiConsole.WriteLine("look - looks around the room");
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("help - shows this help");
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("go - going to another room");
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("pick - pick up the item");
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("inv - shows your current inventory");
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("quit - exits the game");
        }
    }
}
