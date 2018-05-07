using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class SteelSword : Item, IWeapon
    {
        private int _attackValue;
        private bool _isNatural;
        private string _name;
        private double _weight;
        private InventorySlotId _slot;

        public SteelSword(Random randAttack) : base()
        {
            _attackValue = randAttack.Next(13, 26);
            _isNatural = false;
            _name = "Steel Sword";
            _slot = InventorySlotId.WEAPON;


        }

        public int AttackValue
        {
            get { return _attackValue; }
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
            return (base.ToString() + " Attack: " + AttackValue);
        }
    }
}
