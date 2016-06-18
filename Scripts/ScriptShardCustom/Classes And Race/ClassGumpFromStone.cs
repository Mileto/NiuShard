using System;
using Server;
using Server.Network;
using Server.Commands;
using Server.Items;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Server.Mobiles;

namespace Server.Gumps
{
    public class ClassFGump : Gump
    {
        public ClassFGump(Mobile m) : base(0,0)
        {
            AddPage(0);
            AddBackground(143, 117, 496, 336, 9200);
        }
              
    }
}