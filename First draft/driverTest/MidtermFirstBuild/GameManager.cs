using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class GameManager
    {
        private Character _player;
        private Character _enemy;
        private int _depth;
        private bool _gameOver;
        private bool _gameWon;
        private RandomEnemyFactory _enemyFactory;
        private RandomItemFactory _itemFactory;
        private int _inventoryScreenCount;
        //private Item _loot;


        public GameManager(string name)
        {
            _enemyFactory = new RandomEnemyFactory();
            _itemFactory = new RandomItemFactory(_enemyFactory.RandomNum);
            _player = new Character(name, 30);
            _player.Equipped.Equip(InventorySlotId.WEAPON, _itemFactory.BronzeSword());
            _player.Equipped.Equip(InventorySlotId.CHESTPIECE, _itemFactory.Gambeson());
            _player.Bag.AddItem(_itemFactory.SmallPotion());
            _enemy = _enemyFactory.GenerateRandomEnemy(_depth);
            _depth = 1;
            _gameOver = false;
            _gameWon = false;
            _inventoryScreenCount = 0;
        }

        public Character Player
        {
            get { return _player; }
        }
        public Character Enemy
        {
            get { return _enemy; }
        }
        public RandomEnemyFactory EnemyFactory
        {
            get { return _enemyFactory; }
        }
        public int Depth
        {
            get { return _depth; }
        }
        public bool GameOver
        {
            get { return _gameOver; }
        }
        public bool GameWon
        {
            get { return _gameWon; }
        }




        public void performAttackPhase()
        {
            int playerAttack;
            int enemyAttack;

            if (_player.CalcTotalAttackValue() <= _enemy.CalcTotalDefenseValue() && _enemy.CalcTotalAttackValue() <= _player.CalcTotalDefenseValue())
            {
                playerAttack = (_player.CalcTotalAttackValue() + 5) - _enemy.CalcTotalDefenseValue();
                enemyAttack = _enemy.CalcTotalAttackValue() - _player.CalcTotalDefenseValue();
            }
            else
            {
                playerAttack = _player.CalcTotalAttackValue() - _enemy.CalcTotalDefenseValue();
                enemyAttack = _enemy.CalcTotalAttackValue() - _player.CalcTotalDefenseValue();
            }
            
            if(playerAttack <= 0)
            {
                playerAttack = 1;
            }
            if (enemyAttack < 0)
            {
                enemyAttack = 0;
            }

            _enemy.TakeDamage(playerAttack);

            // FIXME: See below
            ISpell enemySpell = _enemy.Equipped.GetItem(InventorySlotId.WEAPON) as ISpell;
            if (enemySpell != null)
            {
                int spellDamage = enemySpell.CastSpell();
                spellDamage -= _player.CalcTotalDefenseValue();
                if (spellDamage > 0)
                {
                    _player.TakeDamage(spellDamage);
                }
            }
            else if (!_enemy.IsDead)
            {
                _player.TakeDamage(enemyAttack);

            }
            

            if(_enemy.Name == "The End" && _enemy.IsDead)
            {
                _gameWon = true;
            }
            if(_enemy.IsDead)
            {
                _depth++;
            }
            if (_player.IsDead)
            {
                System.IO.Stream str = Properties.Resources.death_sound;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                _gameOver = true;
            }

            
        }

        public void GenerateNewEnemy()
        {
            _enemy = _enemyFactory.GenerateRandomEnemy(_depth);
        }

        public void UsePoition(int poitionNumber)
        {
            if(poitionNumber == 1)
            {
                IPotion potion = (IPotion)_player.Equipped.GetItem(InventorySlotId.POTION1);
                _player.TakeDamage(-potion.HealValue);
                _player.Equipped.Unequip(InventorySlotId.POTION1);
            }
            else
            {
                IPotion potion = (IPotion)_player.Equipped.GetItem(InventorySlotId.POTION2);
                _player.TakeDamage(-potion.HealValue);
                _player.Equipped.Unequip(InventorySlotId.POTION2);
            }
        }

        //public void AddToInventoryCount()
        //{
        //    _inventoryScreenCount++;
        //}//fix add when ready to add chests
    }
}
