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
    public class RaceGump : Gump
    {

        public RaceGump(Mobile m)
            : base(0, 0)
        {

            Closable = false;
            Disposable = false;
            Dragable = false;
            Resizable = false;

            AddPage(0);

            AddBackground(143, 117, 496, 336, 9200);

            AddLabel(263, 154, 1280, @"Race Selection");
            AddLabel(248, 193, 0, @"Human");
            AddLabel(251, 240, 0, @"Elf");
            AddLabel(251, 281, 0, @"Dwarf");
            AddLabel(251, 365, 0, @"Halfling");
            AddLabel(252, 322, 0, @"Gnome");
            AddLabel(350, 192, 0, @"Half-Elf");
            AddLabel(350, 238, 0, @"Half-Orc");

            AddButton(225, 240, 209, 208, 1, GumpButtonType.Reply, 0); //Elf
            AddButton(225, 281, 209, 208, 2, GumpButtonType.Reply, 0); //Dwarf
            AddButton(225, 194, 209, 208, 3, GumpButtonType.Reply, 0); //Human
            AddButton(226, 322, 209, 208, 4, GumpButtonType.Reply, 0); //Gnome
            AddButton(225, 364, 209, 208, 5, GumpButtonType.Reply, 0); //Halfling
            AddButton(324, 193, 209, 208, 6, GumpButtonType.Reply, 0); //Half-Elf
            AddButton(324, 239, 209, 208, 7, GumpButtonType.Reply, 0); //Half-Orc

            AddImage(604, 127, 203);
            AddImage(138, 128, 202);
            AddImage(178, 107, 201);
            AddImage(179, 416, 233);
            AddImage(138, 416, 204);
            AddImage(138, 107, 206);
            AddImage(605, 107, 207);
            AddImage(316, 177, 1418);
            AddImage(604, 416, 205);
        }

        public override void OnResponse(NetState state, RelayInfo info) 
        {
            Mobile m = state.Mobile;
            
            PlayerMobile pm = m as PlayerMobile;
            if (pm == null)
                return;

            switch (info.ButtonID)
            {
                case 1:
                {
                    m.Hue = 670;
                    m.SendGump(new ClassGump());
                    break;
                }
                case 2:
                {
                    m.Hue = 2104;
                    m.SendGump(new ClassGump());
                    break;
                }
                case 3:
                {
                    m.SendGump(new ClassGump());
                    break;
                }
                case 4:
                {
                    m.Hue = 1816;
                    m.SendGump(new ClassGump());
                    break;
                }
                case 5:
                {
                    m.Hue = 2009;
                    m.SendGump(new ClassGump());
                    break;
                }
                case 6:
                {
                    m.Hue = 56;
                    m.SendGump(new ClassGump());
                    break;
                }
                case 7:
                {
                    m.Hue = 2128;
                    m.SendGump(new ClassGump());
                    break;
                }
            }
        }
    }
}