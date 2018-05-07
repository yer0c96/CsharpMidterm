using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class Character
    {
        protected StoredItems _bag;
        protected EquippedItems _equipped;
        protected string _name;
        protected int _currentHealth;
        protected bool _dead;

        public Character(string name, int currentHealth)
        {
            _name = name;
            _dead = false;
            _currentHealth = currentHealth;
            
            _bag = new StoredItems(20);
            _equipped = new EquippedItems();
        }

        public StoredItems Bag
        {
            get { return _bag; }
        }
        public EquippedItems Equipped
        {
            get { return _equipped; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int CurrentHealth
        {
            get { return _currentHealth; }
        }
        public bool IsDead
        {
            get { return _dead; }
        }
        

        public double CalcTotalWeight()
        {
            return _bag.CalcTotalWeight() + _equipped.CalcTotalWeight();
        }
        public int CalcTotalAttackValue()
        {
            return _equipped.CalcTotalAttackValue();
        }
        public int CalcTotalDefenseValue()
        {
            return _equipped.CalcTotalDefenseValue();
        }
        public void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            if(_currentHealth <= 0)
            {
                
                _dead = true;
                _currentHealth = 0;
            }
        }
        public void Pickup(Item item)
        {
            _bag.AddItem(item);
        }
        public void UnequipAll()
        {
            // FIXME: can use a loop here
            Item removedItem;

            removedItem = _equipped.Unequip(InventorySlotId.HELMET);
            if(removedItem != null && !removedItem.IsNatural)
            {
                Pickup(removedItem);
            }
            removedItem = _equipped.Unequip(InventorySlotId.CHESTPIECE);
            if (removedItem != null && !removedItem.IsNatural)
            {
                Pickup(removedItem);
            }
            removedItem = _equipped.Unequip(InventorySlotId.GREAVES);
            if (removedItem != null && !removedItem.IsNatural)
            {
                Pickup(removedItem);
            }
            removedItem = _equipped.Unequip(InventorySlotId.VAMBRACES);
            if (removedItem != null && !removedItem.IsNatural)
            {
                Pickup(removedItem);
            }
            removedItem = _equipped.Unequip(InventorySlotId.WEAPON);
            if (removedItem != null && !removedItem.IsNatural)
            {
                Pickup(removedItem);
            }
            removedItem = _equipped.Unequip(InventorySlotId.POTION1);
            if (removedItem != null && !removedItem.IsNatural)
            {
                Pickup(removedItem);
            }
            removedItem = _equipped.Unequip(InventorySlotId.POTION2);
            if (removedItem != null && !removedItem.IsNatural)
            {
                Pickup(removedItem);
            }
        }
    }
}
