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
    public class ClassFGump : Gump
    {
        private Mobile m;

        public ClassFGump(Mobile m) : base(0, 0)
        {
            Closable = false;
            Disposable = false;
            Dragable = false;
            Resizable = false;

            //START SETUP GRAFICA
            AddPage(0);
            AddBackground(143, 117, 496, 336, 9200);

            AddLabel(253, 144, 1280, @"Class Selection");
            AddLabel(229, 186, 0, @"Warrior");
            AddLabel(229, 215, 0, @"Mage");

            /*
            AddLabel(229, 244, 0, @"Riccardo");
            AddLabel(229, 302, 0, @"Obeso");
            AddLabel(229, 273, 0, @"Caligola");
            AddLabel(229, 330, 0, @"Piglianculo");
            AddLabel(229, 357, 0, @"Offese");
            AddLabel(229, 384, 0, @"Al");
            AddLabel(365, 187, 0, @"Dio");
            AddLabel(365, 215, 0, @"Sciamano");
            AddLabel(365, 244, 0, @"Ma");
            AddLabel(365, 272, 0, @"Simpatico");
            */

            AddButton(202, 186, 209, 208, 1, GumpButtonType.Reply, 0); //Warrior
            AddButton(202, 215, 209, 208, 2, GumpButtonType.Reply, 0); //Mage

            /*
            AddButton(202, 357, 209, 208, 3, GumpButtonType.Reply, 0); //Priest
            AddButton(202, 244, 209, 208, 4, GumpButtonType.Reply, 0); //Druid
            AddButton(202, 302, 209, 208, 5, GumpButtonType.Reply, 0); //Monk
            AddButton(202, 330, 209, 208, 6, GumpButtonType.Reply, 0); //Paladin
            AddButton(202, 273, 209, 208, 7, GumpButtonType.Reply, 0); //Mage
            AddButton(202, 384, 209, 208, 8, GumpButtonType.Reply, 0); //Ranger
            AddButton(337, 187, 209, 208, 9, GumpButtonType.Reply, 0); //Rogue
            AddButton(337, 215, 209, 208, 10, GumpButtonType.Reply, 0); //Shaman
            AddButton(337, 244, 209, 208, 11, GumpButtonType.Reply, 0); //Warlock
            AddButton(337, 272, 209, 208, 12, GumpButtonType.Reply, 0); //Warrior
            */

            //END SETUP GRAFICA
        }

        public override void OnResponse(NetState state, RelayInfo info)
        {
            Mobile m = state.Mobile;

            PlayerMobile pm = m as PlayerMobile;
            if (pm == null)
                return;

            switch(info.ButtonID)
            {
                case 1:
                    {
                        m.Title = ", the Warrior";

                        m.Skills.Alchemy.Cap = 0;
                        m.Skills.Anatomy.Cap = 100;
                        m.Skills.AnimalLore.Cap = 0;
                        m.Skills.AnimalTaming.Cap = 0;
                        m.Skills.Archery.Cap = 0;
                        m.Skills.ArmsLore.Cap = 0;
                        m.Skills.Begging.Cap = 0;
                        m.Skills.Blacksmith.Cap = 0;
                        m.Skills.Bushido.Cap = 0;
                        m.Skills.Camping.Cap = 0;
                        m.Skills.Carpentry.Cap = 0;
                        m.Skills.Cartography.Cap = 0;
                        m.Skills.Chivalry.Cap = 0;
                        m.Skills.Cooking.Cap = 0;
                        m.Skills.DetectHidden.Cap = 0;
                        m.Skills.Discordance.Cap = 0;
                        m.Skills.EvalInt.Cap = 0;
                        m.Skills.Fencing.Cap = 100;
                        m.Skills.Fishing.Cap = 0;
                        m.Skills.Fletching.Cap = 0;
                        m.Skills.Focus.Cap = 100;
                        m.Skills.Forensics.Cap = 0;
                        m.Skills.Healing.Cap = 0;
                        m.Skills.Herding.Cap = 0;
                        m.Skills.Hiding.Cap = 0;
                        m.Skills.Inscribe.Cap = 0;
                        m.Skills.ItemID.Cap = 0;
                        m.Skills.Lockpicking.Cap = 0;
                        m.Skills.Lumberjacking.Cap = 0;
                        m.Skills.Macing.Cap = 100;
                        m.Skills.Magery.Cap = 0;
                        m.Skills.MagicResist.Cap = 100;
                        m.Skills.Meditation.Cap = 0;
                        m.Skills.Mining.Cap = 0;
                        m.Skills.Musicianship.Cap = 0;
                        m.Skills.Necromancy.Cap = 0;
                        m.Skills.Ninjitsu.Cap = 0;
                        m.Skills.Parry.Cap = 100;
                        m.Skills.Peacemaking.Cap = 0;
                        m.Skills.Poisoning.Cap = 100;
                        m.Skills.Provocation.Cap = 0;
                        m.Skills.RemoveTrap.Cap = 0;
                        m.Skills.Snooping.Cap = 0;
                        m.Skills.Spellweaving.Cap = 0;
                        m.Skills.SpiritSpeak.Cap = 0;
                        m.Skills.Stealing.Cap = 0;
                        m.Skills.Stealth.Cap = 0;
                        m.Skills.Swords.Cap = 100;
                        m.Skills.Tactics.Cap = 100;
                        m.Skills.Tailoring.Cap = 0;
                        m.Skills.TasteID.Cap = 100;
                        m.Skills.Tinkering.Cap = 0;
                        m.Skills.Tracking.Cap = 0;
                        m.Skills.Veterinary.Cap = 0;
                        m.Skills.Wrestling.Cap = 0;
                        m.Skills.TasteID.Cap = 0;

                        //Edit actual Skill Values here
                        m.Skills.Alchemy.Base = 0;
                        m.Skills.Anatomy.Base = 0;
                        m.Skills.AnimalLore.Base = 0;
                        m.Skills.AnimalTaming.Base = 0;
                        m.Skills.Archery.Base = 0;
                        m.Skills.ArmsLore.Base = 0;
                        m.Skills.Begging.Base = 0;
                        m.Skills.Blacksmith.Base = 0;
                        m.Skills.Camping.Base = 0;
                        m.Skills.Carpentry.Base = 0;
                        m.Skills.Cartography.Base = 0;
                        m.Skills.Cooking.Base = 0;
                        m.Skills.DetectHidden.Base = 0;
                        m.Skills.Discordance.Base = 0;
                        m.Skills.EvalInt.Base = 0;
                        m.Skills.Fishing.Base = 0;
                        m.Skills.Fencing.Base = 0;
                        m.Skills.Fletching.Base = 0;
                        m.Skills.Focus.Base = 0;
                        m.Skills.Forensics.Base = 0;
                        m.Skills.Healing.Base = 0;
                        m.Skills.Herding.Base = 0;
                        m.Skills.Hiding.Base = 0;
                        m.Skills.Inscribe.Base = 0;
                        m.Skills.ItemID.Base = 0;
                        m.Skills.Lockpicking.Base = 0;
                        m.Skills.Lumberjacking.Base = 0;
                        m.Skills.Macing.Base = 0;
                        m.Skills.Magery.Base = 0;
                        m.Skills.MagicResist.Base = 0;
                        m.Skills.Meditation.Base = 0;
                        m.Skills.Mining.Base = 0;
                        m.Skills.Musicianship.Base = 0;
                        m.Skills.Parry.Base = 0;
                        m.Skills.Peacemaking.Base = 0;
                        m.Skills.Poisoning.Base = 0;
                        m.Skills.Provocation.Base = 0;
                        m.Skills.RemoveTrap.Base = 0;
                        m.Skills.Snooping.Base = 0;
                        m.Skills.Spellweaving.Base = 0;
                        m.Skills.SpiritSpeak.Base = 0;
                        m.Skills.Stealing.Base = 0;
                        m.Skills.Stealth.Base = 0;
                        m.Skills.Swords.Base = 0;
                        m.Skills.Tactics.Base = 0;
                        m.Skills.Tailoring.Base = 0;
                        m.Skills.Tinkering.Base = 0;
                        m.Skills.Tracking.Base = 0;
                        m.Skills.Veterinary.Base = 0;
                        m.Skills.Wrestling.Base = 0;
                        m.Skills.Bushido.Base = 0;
                        m.Skills.Ninjitsu.Base = 0;
                        m.Skills.Chivalry.Base = 0;
                        m.Skills.Necromancy.Base = 0;
                        m.Skills.TasteID.Base = 0;

                        m.SendGump(new PSkillWarrior());
                        break;
                    }
                case 2: //Bard
                    {
                        //Edit Skill/Stat TOTAL cap here
                        m.SkillsCap = 1200;
                        m.StatCap = 225;

                        //Edit Base Stats values here
                        m.Str = 30;
                        m.Dex = 20;
                        m.Int = 30;

                        //Edit Class Title here.  This is the title next to the players name above their head
                        m.Title = ", the Magician";

                        //Edit Starting Equiptment here

                        //Edit Skill Caps here
                        m.Skills.Alchemy.Cap = 0;
                        m.Skills.Anatomy.Cap = 0;
                        m.Skills.AnimalLore.Cap = 0;
                        m.Skills.AnimalTaming.Cap = 0;
                        m.Skills.Archery.Cap = 0;
                        m.Skills.ArmsLore.Cap = 0;
                        m.Skills.Begging.Cap = 0;
                        m.Skills.Blacksmith.Cap = 0;
                        m.Skills.Bushido.Cap = 0;
                        m.Skills.Camping.Cap = 0;
                        m.Skills.Carpentry.Cap = 0;
                        m.Skills.Cartography.Cap = 0;
                        m.Skills.Chivalry.Cap = 0;
                        m.Skills.Cooking.Cap = 0;
                        m.Skills.DetectHidden.Cap = 0;
                        m.Skills.Discordance.Cap = 0;
                        m.Skills.EvalInt.Cap = 0;
                        m.Skills.Fencing.Cap = 0;
                        m.Skills.Fishing.Cap = 0;
                        m.Skills.Fletching.Cap = 0;
                        m.Skills.Focus.Cap = 0;
                        m.Skills.Forensics.Cap = 0;
                        m.Skills.Healing.Cap = 0;
                        m.Skills.Herding.Cap = 0;
                        m.Skills.Hiding.Cap = 0;
                        m.Skills.Inscribe.Cap = 0;
                        m.Skills.ItemID.Cap = 0;
                        m.Skills.Lockpicking.Cap = 0;
                        m.Skills.Lumberjacking.Cap = 0;
                        m.Skills.Macing.Cap = 0;
                        m.Skills.Magery.Cap = 0;
                        m.Skills.MagicResist.Cap = 100;
                        m.Skills.Meditation.Cap = 0;
                        m.Skills.Mining.Cap = 0;
                        m.Skills.Musicianship.Cap = 100;
                        m.Skills.Necromancy.Cap = 0;
                        m.Skills.Ninjitsu.Cap = 0;
                        m.Skills.Parry.Cap = 0;
                        m.Skills.Peacemaking.Cap = 100;
                        m.Skills.Poisoning.Cap = 0;
                        m.Skills.Provocation.Cap = 100;
                        m.Skills.RemoveTrap.Cap = 0;
                        m.Skills.Snooping.Cap = 0;
                        m.Skills.Spellweaving.Cap = 0;
                        m.Skills.SpiritSpeak.Cap = 0;
                        m.Skills.Stealing.Cap = 0;
                        m.Skills.Stealth.Cap = 0;
                        m.Skills.Swords.Cap = 0;
                        m.Skills.Tactics.Cap = 100;
                        m.Skills.Tailoring.Cap = 0;
                        m.Skills.TasteID.Cap = 0;
                        m.Skills.Tinkering.Cap = 0;
                        m.Skills.Tracking.Cap = 0;
                        m.Skills.Veterinary.Cap = 0;
                        m.Skills.Wrestling.Cap = 0;

                        //Edit actual Skill Values here
                        m.Skills.Alchemy.Base = 0;
                        m.Skills.Anatomy.Base = 0;
                        m.Skills.AnimalLore.Base = 0;
                        m.Skills.AnimalTaming.Base = 0;
                        m.Skills.Archery.Base = 0;
                        m.Skills.ArmsLore.Base = 0;
                        m.Skills.Begging.Base = 0;
                        m.Skills.Blacksmith.Base = 0;
                        m.Skills.Camping.Base = 0;
                        m.Skills.Carpentry.Base = 0;
                        m.Skills.Cartography.Base = 0;
                        m.Skills.Cooking.Base = 0;
                        m.Skills.DetectHidden.Base = 0;
                        m.Skills.Discordance.Base = 0;
                        m.Skills.EvalInt.Base = 0;
                        m.Skills.Fishing.Base = 0;
                        m.Skills.Fencing.Base = 0;
                        m.Skills.Fletching.Base = 0;
                        m.Skills.Focus.Base = 0;
                        m.Skills.Forensics.Base = 0;
                        m.Skills.Healing.Base = 0;
                        m.Skills.Herding.Base = 0;
                        m.Skills.Hiding.Base = 0;
                        m.Skills.Inscribe.Base = 0;
                        m.Skills.ItemID.Base = 0;
                        m.Skills.Lockpicking.Base = 0;
                        m.Skills.Lumberjacking.Base = 0;
                        m.Skills.Macing.Base = 0;
                        m.Skills.Magery.Base = 0;
                        m.Skills.MagicResist.Base = 0;
                        m.Skills.Meditation.Base = 0;
                        m.Skills.Mining.Base = 0;
                        m.Skills.Musicianship.Base = 0;
                        m.Skills.Parry.Base = 0;
                        m.Skills.Peacemaking.Base = 0;
                        m.Skills.Poisoning.Base = 0;
                        m.Skills.Provocation.Base = 0;
                        m.Skills.RemoveTrap.Base = 0;
                        m.Skills.Snooping.Base = 0;
                        m.Skills.Spellweaving.Base = 0;
                        m.Skills.SpiritSpeak.Base = 0;
                        m.Skills.Stealing.Base = 0;
                        m.Skills.Stealth.Base = 0;
                        m.Skills.Swords.Base = 0;
                        m.Skills.Tactics.Base = 0;
                        m.Skills.Tailoring.Base = 0;
                        m.Skills.TasteID.Base = 0;
                        m.Skills.Tinkering.Base = 0;
                        m.Skills.Tracking.Base = 0;
                        m.Skills.Veterinary.Base = 0;
                        m.Skills.Wrestling.Base = 0;
                        m.Skills.Bushido.Base = 0;
                        m.Skills.Ninjitsu.Base = 0;
                        m.Skills.Chivalry.Base = 0;
                        m.Skills.Necromancy.Base = 0;

                        m.SendGump(new PSkillMage());
                        break;
                    }
            }
        }
    }

}