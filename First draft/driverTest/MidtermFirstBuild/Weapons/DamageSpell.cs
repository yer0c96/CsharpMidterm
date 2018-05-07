using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class DamageSpell : Item, IWeapon, ISpell
    {
        private int _attackValue;
        private bool _isNatural;
        private string _name;
        private double _weight;
        private InventorySlotId _slot;
        private int _currentCharges;
        private int _maxCharges;
        private int _chargersPerUse;


        public DamageSpell()
        {
            _attackValue = 45;
            _isNatural = true;
            _name = "Storm of 100 fists";
            _weight = 0;
            _slot = InventorySlotId.WEAPON;
            _currentCharges = 1;
            _maxCharges = 1;
            _chargersPerUse = 1;
        }

        public int CurrentCharges
        {
            get { return _currentCharges; }
            set { _currentCharges = value; }
        }
        public int MaxCharges
        {
            get { return _maxCharges; }

        }
        public int ChargesPerUse
        {
            get { return _chargersPerUse; }
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

        public int CastSpell()
        {
            // Grants an extra attack every three turns

            if(_currentCharges < -1)
            {
                _currentCharges = MaxCharges;
                return 0;
            }else if(_currentCharges < 0)
            {
                _currentCharges -= _chargersPerUse;
                return 0;
            }
            else
            {
                _currentCharges -= _chargersPerUse;
                return _attackValue;
            }


            //if(_currentCharges >= 0)
            //{
            //    _currentCharges -= _chargersPerUse;
            //    return _attackValue;
            //}else if(_currentCharges >= -2)
            //{
            //    _currentCharges -= _chargersPerUse;
            //    return 0;
            //}
            //else
            //{
            //    _currentCharges = MaxCharges;
            //    return _attackValue;
            //}
        } 
    }
}
