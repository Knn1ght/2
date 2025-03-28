using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class Sword : BaseItem
    {
        public override string Name => "Sword";

        public override string Description => "Almost fully broken sword";

        public override int Weight => 5;
    }
}
