using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class RandomItemFactory
    {
        private Random _random;


        public RandomItemFactory(Random random)
        {
            _random = random;
        }

        

        public Item GenerateItem(int enemyDifficulty)
        {
            int ranItem = _random.Next(1, 7);
            int randNum = _random.Next(0, 133);

            if (enemyDifficulty == 1)
            {
                if (randNum <= 1)
                {
                    return UltraSword();
                }
                else if (randNum <= 11)
                {
                    return SmallPotion();
                }
                else if (randNum <= 21)
                {
                    return MediumPotion();
                }
                else if (randNum <= 31)
                {
                    return RandomPotion();
                }
                else if (randNum <= 41)
                {
                    return BronzeSword();
                }
                else if (randNum <= 51)
                {
                    return Gambeson();
                }
                else if (randNum <= 61)
                {
                    return BronzeHelmet();
                }
                else if (randNum <= 71)
                {
                    return BronzeGreaves();
                }
                else if (randNum <= 81)
                {
                    return BronzeVambraces();
                }
                else if (randNum <= 91)
                {
                    return IronSword();
                }
                else if (randNum <= 101)
                {
                    return IronChestpiece();
                }
                else if (randNum <= 111)
                {
                    return IronHelmet();
                }
                else if (randNum <= 121)
                {
                    return IronGreaves();
                }
                else
                {
                    return IronVambraces();
                }
            }
            else if (enemyDifficulty == 2)
            {
                if (randNum <= 1)
                {
                    return UltraSword();
                }
                else if (randNum <= 11)
                {
                    return LargePotion();
                }
                else if (randNum <= 21)
                {
                    return MediumPotion();
                }
                else if (randNum <= 31)
                {
                    return RandomPotion();
                }
                else if (randNum <= 41)
                {
                    return SteelSword();
                }
                else if (randNum <= 51)
                {
                    return SteelChestpiece();
                }
                else if (randNum <= 61)
                {
                    return SteelHelmet();
                }
                else if (randNum <= 71)
                {
                    return SteelGreaves();
                }
                else if (randNum <= 81)
                {
                    return SteelVambraces();
                }
                else if (randNum <= 91)
                {
                    return IronSword();
                }
                else if (randNum <= 101)
                {
                    return IronChestpiece();
                }
                else if (randNum <= 111)
                {
                    return IronHelmet();
                }
                else if (randNum <= 121)
                {
                    return IronGreaves();
                }
                else
                {
                    return IronVambraces();
                }
            }
            else
            {
                if (randNum <= 15)
                {
                    return SteelVambraces();
                }
                else if (randNum <= 30)
                {
                    return RandomPotion();
                }
                else if (randNum <= 45)
                {
                    return LargePotion();
                }
                else if (randNum <= 60)
                {
                    return SteelSword();
                }
                else if (randNum <= 75)
                {
                    return SteelChestpiece();
                }
                else if (randNum <= 90)
                {
                    return SteelHelmet();
                }
                else if (randNum <= 105)
                {
                    return SteelGreaves();
                }
                else
                {
                    return UltraSword();
                }
            }
        }

        public Item DamageSpell()
        {
            DamageSpell spell = new DamageSpell();
            return spell;
        }
        public Item Natural(int lowerRange, int upperRange)
        {
            NaturalWeapon weapon = new NaturalWeapon(_random, lowerRange, upperRange);
            return weapon;
        }
        public Item BronzeSword()
        {
            BronzeSword sword = new BronzeSword(_random);
            return sword;
        }
        public Item IronSword()
        {
            IronSword sword = new IronSword(_random);
            return sword;
        }
        public Item SteelSword()
        {
            SteelSword sword = new SteelSword(_random);
            return sword;
        }
        public Item UltraSword()
        {
            UltraSword sword = new UltraSword(_random);
            return sword;
        }

        public Item BronzeHelmet()
        {
            BronzeHelmet sword = new BronzeHelmet(_random);
            return sword;
        }
        public Item IronHelmet()
        {
            IronHelmet sword = new IronHelmet(_random);
            return sword;
        }
        public Item SteelHelmet()
        {
            SteelHelmet sword = new SteelHelmet(_random);
            return sword;
        }

        public Item Gambeson()
        {
            Gambeson armor = new Gambeson(_random);
            return armor;
        }
        public Item IronChestpiece()
        {
            IronChestpiece armor = new IronChestpiece(_random);
            return armor;
        }
        public Item SteelChestpiece()
        {
            SteelChestPiece armor = new SteelChestPiece(_random);
            return armor;
        }

        public Item BronzeVambraces()
        {
            BronzeVambraces armor = new BronzeVambraces(_random);
            return armor;
        }
        public Item IronVambraces()
        {
            IronVambraces armor = new IronVambraces(_random);
            return armor;
        }
        public Item SteelVambraces()
        {
            SteelVambraces armor = new SteelVambraces(_random);
            return armor;
        }

        public Item BronzeGreaves()
        {
            BronzeGreaves armor = new BronzeGreaves(_random);
            return armor;
        }
        public Item IronGreaves()
        {
            IronGreaves armor = new IronGreaves(_random);
            return armor;
        }
        public Item SteelGreaves()
        {
            SteelGreaves armor = new SteelGreaves(_random);
            return armor;
        }

        public Item SmallPotion()
        {
            SmallHealthPotion armor = new SmallHealthPotion(_random);
            return armor;
        }
        public Item MediumPotion()
        {
            MediumHealthPotion armor = new MediumHealthPotion(_random);
            return armor;
        }
        public Item LargePotion()
        {
            LargeHealthPotion armor = new LargeHealthPotion(_random);
            return armor;
        }
        public Item RandomPotion()
        {
            RandomHealthPotion armor = new RandomHealthPotion(_random);
            return armor;
        }
    }
}
