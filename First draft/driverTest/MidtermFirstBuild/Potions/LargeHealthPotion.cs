using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    class LargeHealthPotion : Item, IPotion
    {
        private int _healValue;
        private bool _isNatural;
        private string _name;
        private double _weight;
        private InventorySlotId _slot;
        private InventorySlotId _slot2;

        public LargeHealthPotion(Random healValue) : base()
        {
            _healValue = healValue.Next(25, 31);
            _name = "Large Health Potion";
            _slot = InventorySlotId.POTION1;
            _slot2 = InventorySlotId.POTION2;
        }

        public int HealValue
        {
            get { return _healValue; }
        }

        public override bool IsNatural
        {
            get { return _isNatural; }
        }
        public override string Name
        {
            get { return _name; }
        }

        public override double Weight
        {
            get { return _weight; }
        }

        public override InventorySlotId Slot
        {
            get { return _slot; }
        }

        public InventorySlotId Slot2
        {
            get { return _slot2; }
        }

        public override string ToString()
        {
            return (base.ToString() + " Heal value: " + _healValue);
        }
    }
}
