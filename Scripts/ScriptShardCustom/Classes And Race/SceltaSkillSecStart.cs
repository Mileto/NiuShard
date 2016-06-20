using System;
using Server;
using Server.Network;
using Server.Commands;
using Server.Items;
using Server.Mobiles;
using Server.Gumps;
using Server.Spells;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Server.Gumps
{
    public class SecSkillWarrior : Gump
    {
        private Mobile m;

        public SecSkillWarrior() : base(0, 0)
        {
            Closable = false;
            Disposable = false;
            Dragable = false;
            Resizable = false;

            AddPage(0);
            AddBackground(143, 118, 496, 336, 9200);

            AddLabel(224, 146, 1280, @"Primary Skill");
            AddLabel(229, 186, 0, @"SwordManship");
            AddLabel(229, 215, 0, @"Fencing");
            AddLabel(229, 244, 0, @"MaceFighting");

            AddButton(203, 186, 209, 208, 1, GumpButtonType.Reply, 0); //Sword
            AddButton(203, 215, 209, 208, 2, GumpButtonType.Reply, 0); //Fencer
            AddButton(203, 244, 209, 208, 3, GumpButtonType.Reply, 0); //MaceFighter
        }

        public override void OnResponse(NetState state, RelayInfo info)
        {
            Mobile m = state.Mobile;

            PlayerMobile pm = m as PlayerMobile;

            if (pm == null)
                return;

            switch (info.ButtonID)
            {
                case 1: //Sword
                    {
                        if (m.Skills.Swords.Base == 50)
                        {
                            m.SendGump(new SecSkillWarrior());
                        }
                        //Edit Skill Caps
                        m.Skills.Swords.Cap = 100;
                        m.Skills.Swords.Base = 50;

                        break;
                    }

                case 2: //Fencing
                    {
                        if (m.Skills.Fencing.Base == 50)
                        {
                            m.SendGump(new SecSkillWarrior());
                        }

                        //Edit Skill Caps
                        m.Skills.Fencing.Cap = 100;
                        m.Skills.Fencing.Base = 50;

                        break;
                    }
                case 3: //Macing
                    {
                        if (m.Skills.Macing.Base == 50)
                        {
                            m.SendGump(new SecSkillWarrior());
                        }

                        //Edit Skill Caps
                        m.Skills.Macing.Cap = 100;
                        m.Skills.Macing.Base = 50;

                        break;
                }
            }
        }
    }


    public class SecSkillMage : Gump
    {
        private Mobile m;

        public SecSkillMage() : base(0, 0)
        {
            Closable = false;
            Disposable = false;
            Dragable = false;
            Resizable = false;

            AddPage(0);
            AddBackground(143, 118, 496, 336, 9200);

            AddLabel(224, 146, 1280, @"Secondary Skill");
            AddLabel(229, 186, 0, @"Magery");
            AddLabel(229, 215, 0, @"Meditation");
            AddLabel(229, 244, 0, @"Evaluating Intelligence");


            AddButton(203, 186, 209, 208, 1, GumpButtonType.Reply, 0); //Magery
            AddButton(203, 215, 209, 208, 2, GumpButtonType.Reply, 0); //Meditation
            AddButton(203, 244, 209, 208, 3, GumpButtonType.Reply, 0); //EvallInt
        }

        public override void OnResponse(NetState state, RelayInfo info)
        {
            Mobile m = state.Mobile;

            PlayerMobile pm = m as PlayerMobile;

            if (pm == null)
                return;

            switch (info.ButtonID)
            {
                case 1: //Magery
                    {
                        if(m.Skills.Magery.Base == 50)
                        {
                            m.SendGump(new SecSkillMage());
                        }
                        //Edit Skill Caps
                        m.Skills.Magery.Cap = 100;
                        m.Skills.Magery.Base = 50;
                        break;
                    }

                case 2: //Medit
                    {
                        if (m.Skills.Meditation.Base == 50)
                        {
                            m.SendGump(new SecSkillMage());
                        }
                        //Edit Skill Caps
                        m.Skills.Meditation.Cap = 100;
                        m.Skills.Meditation.Base = 50;
                        break;
                    }
                case 3: //EvallInt
                    {
                        if (m.Skills.EvalInt.Base == 50)
                        {
                            m.SendGump(new SecSkillMage());
                        }
                        //Edit Skill Caps
                        m.Skills.EvalInt.Cap = 100;
                        m.Skills.EvalInt.Base = 50;
                        break;
                    }
            }
        }
    }
}