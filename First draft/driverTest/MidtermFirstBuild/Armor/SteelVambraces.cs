using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    class SteelVambraces : Item, IArmor
    {
        private int _defenseValue;
        private bool _isNatural;
        private string _name;
        private double _weight;
        private InventorySlotId _slot;

        public SteelVambraces(Random randAttack) : base()
        {
            _defenseValue = randAttack.Next(7, 14);
            _isNatural = false;
            _name = "Steel Vambraces";
            _slot = InventorySlotId.VAMBRACES;

        }

        public int DefenseValue
        {
            get { return _defenseValue; }
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

        public override string ToString()
        {
            return (base.ToString() + " Defense: " + DefenseValue);
        }
    }
}
