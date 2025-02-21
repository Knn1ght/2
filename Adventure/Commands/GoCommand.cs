using Adventure.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class GoCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {            
            if (!@params.Any())
            {

                return;
            }

            //bool FindRoom(BaseRoom n)
            //{
            //    return n.Name == @params[0];
            //}

            var room = world.CurrentRoom.Neighbours.FirstOrDefault(n => n.Name == @params[0]);
            if (room == null)
            {
                AnsiConsole.WriteLine($"Wrong room[red]");
                return;
            
            }
            world.SwitchRoom(room);
            AnsiConsole.WriteLine($"You are in {(world.CurrentRoom)} right now");
           
        }
             
        
    }
}
