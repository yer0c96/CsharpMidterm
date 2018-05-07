using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class EquippedItems
    {
        private Item[] _slots;
        public EquippedItems()
        {
            _slots = new Item[8];
        }

        public Item GetItem(InventorySlotId slot)
        {
            return _slots[(int)slot];
        }
        
        public Item Equip(InventorySlotId slot, Item item)
        {
            Item oldItem = null;

            if (slot == InventorySlotId.POTION1 || slot == InventorySlotId.POTION2)
            {
                if (_slots[6] == null)
                {
                    _slots[6] = item;
                }
                else if (_slots[7] == null)
                {
                    _slots[7] = item;
                }
                else
                {
                    // FIXME: Use (int)slot instead of always assigning to 6
                    oldItem = _slots[6];
                    _slots[6] = item;
                }
                return oldItem;
            }
            else
            {
                oldItem = _slots[(int)slot];
                _slots[(int)slot] = item;
                return oldItem;
            }
        }

        public Item Unequip(InventorySlotId slot)
        {
            Item itemToUnequip = _slots[(int)slot];
            _slots[(int)slot] = null;
            return itemToUnequip;
        }

        public double CalcTotalWeight()
        {
            double sum = 0;
            for (int i = 0; i < _slots.Length; i++)
            {
                if (_slots[i] != null)
                {
                    sum += _slots[i].Weight;
                }
            }
            return sum;
        }
        public int CalcTotalAttackValue()
        {
            int sum = 0;
            for (int i = 0; i < _slots.Length; i++)
            {
                IWeapon weapon = _slots[i] as IWeapon;
                if(weapon != null)
                {
                    sum += weapon.AttackValue;
                }
            }
                return sum;
        }
        public int CalcTotalDefenseValue()
        {
            int sum = 0;
            for (int i = 0; i < _slots.Length; i++)
            {
                IArmor armor = _slots[i] as IArmor;
                if (armor != null)
                {
                    sum += armor.DefenseValue;
                }
            }
            return sum;
        }
    }
}
