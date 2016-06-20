using System;
using Server.Items;
using Server.Gumps;

/*
namespace Server.Items
{
    public class ClassStone : Item
    {
        public override string DefaultName
        {
            get { return "Class Stone"; }
        }

        [Constructable]
        public ClassStone() : base(0xED4)
        {
            Movable = false;
            Hue = 0x2D1;
        }
  
        
        public override void OnDoubleClick(Mobile from)
        {
            from.SendGump(new ClassGump(from));
        }
        

        public ClassStone(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}

*/