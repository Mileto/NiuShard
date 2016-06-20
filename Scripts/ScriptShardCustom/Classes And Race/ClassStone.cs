using System;
using Server.Items;
using Server.Gumps;


namespace Server.Items
{
    public class ClassStone : Item
    {
        public override string DefaultName
        {
            get { return "Class Stone"; }
        }

        //definisco la struttura in gioco dell'item.

        [Constructable]
        public ClassStone() : base(0xED4)
        {
            Movable = false;
            Hue = 0x2D1;
        }
  
        
        public override void OnDoubleClick(Mobile from)
        {
            from.SendGump(new ClassFGump(from));
        }
        
        public ClassStone(Serial serial) : base(serial) //è il costruttore
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

