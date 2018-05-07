using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class RandomEnemyFactory
    {
        private Random _random = new Random();
        private RandomItemFactory _itemFactory;
        private int _randCharacter;

        public RandomEnemyFactory()
        {

            _itemFactory = new RandomItemFactory(_random);
            //fix


        }

        public Random RandomNum
        {
            get { return _random; }
        }

        public Character GenerateRandomEnemy(int depth)
        {
            if(depth == 20)
            {
                Character boss = new Character("The End", 100);
                boss.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.UltraSword());
                boss.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.SteelChestpiece());
                boss.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SteelHelmet());
                boss.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SteelGreaves());
                boss.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SteelVambraces());
            }
            else if(depth == 15)
            {
                Character boss = new Character("The Shatterd One", 85);
                boss.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.UltraSword());
                boss.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.SteelChestpiece());
                boss.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SteelHelmet());
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                return boss;
            }
            else if (depth == 10)
            {
                Character boss = new Character("The Guardian", 75);
                boss.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.UltraSword());
                boss.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.SteelChestpiece());
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                return boss;
            }
            else if (depth == 5)
            {
                Character boss = new Character("Agatha the crusher", 40);
                boss.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.IronSword());
                boss.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.IronChestpiece());
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                boss.Bag.AddItem(_itemFactory.GenerateItem(3));
                return boss;
            }
            else if (depth <= 3)
            {
                _randCharacter = _random.Next(0, 106);
            }
            else if (depth <= 9)
            {
                _randCharacter = _random.Next(0, 136);
            }
            else
            {
                _randCharacter = _random.Next(135, 166);
            }

            if (_randCharacter <= 35)
            {
                Character goblin = new Character("Goblin", 15);
                goblin.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.BronzeSword());
                goblin.Bag.AddItem(_itemFactory.GenerateItem(1));
                return goblin;
            }
            else if (_randCharacter <= 70)
            {
                Character rat = new Character("Rat", 5);
                rat.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.Natural(1, 5));
                rat.Bag.AddItem(_itemFactory.GenerateItem(1));
                return rat;
            }
            else if (_randCharacter <= 105)
            {
                Character undead = new Character("Undead", 8);
                undead.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.Natural(5, 11));
                undead.Bag.AddItem(_itemFactory.GenerateItem(1));
                return undead;
            }
            else if (_randCharacter <= 120)
            {
                Character kobold = new Character("Kobold", 20);
                kobold.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.BronzeSword());
                kobold.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.Gambeson());
                kobold.Bag.AddItem(_itemFactory.GenerateItem(2));
                return kobold;
            }
            else if(_randCharacter <= 135)
            {
                Character orc = new Character("Orc", 30);
                orc.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.IronSword());
                orc.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.IronChestpiece());
                orc.Bag.AddItem(_itemFactory.GenerateItem(2));
                return orc;
            }
            else if (_randCharacter <= 150)
            {
                Character Wizard = new Character("Wizard", 45);
                Wizard.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.DamageSpell());
                Wizard.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.IronChestpiece());
                Wizard.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SteelHelmet());
                Wizard.Bag.AddItem(_itemFactory.GenerateItem(3));
                return Wizard;
            }
            else if (_randCharacter <= 165)
            {
                Character Juggernaught = new Character("Juggernaught", 55);
                Juggernaught.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.SteelSword());
                Juggernaught.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.IronChestpiece());
                Juggernaught.Equipped.Equip(InventorySlotId.HELMET, _itemFactory.SteelHelmet());
                Juggernaught.Equipped.Equip(InventorySlotId.VAMBRACES, _itemFactory.SteelVambraces());
                Juggernaught.Equipped.Equip(InventorySlotId.GREAVES, _itemFactory.SteelGreaves());
                Juggernaught.Bag.AddItem(_itemFactory.GenerateItem(3));
                return Juggernaught;
            }
            else
            {
                Character Dragon = new Character("Dragon", 70);
                Dragon.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.Natural(60, 70));
                Dragon.Bag.AddItem(_itemFactory.GenerateItem(3));
                Dragon.Bag.AddItem(_itemFactory.GenerateItem(3));
                return Dragon;
            }
            //return null;
        }

    }
}
