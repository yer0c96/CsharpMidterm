using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class NaturalWeapon : Item, IWeapon
    {
        private int _attackValue;
        private bool _isNatural;
        private string _name;
        private double _weight;
        private InventorySlotId _slot;

        public NaturalWeapon(Random randAttack, int lowerRange, int upperRange) : base()
        {
            //int swordAttack = randAttack.Next(4, 11);
            _attackValue = randAttack.Next(lowerRange, upperRange + 1);
            _isNatural = true;
            _name = "Natural";
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
