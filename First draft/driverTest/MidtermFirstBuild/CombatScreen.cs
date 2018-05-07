using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermFirstBuild
{
    public partial class CombatScreen : UserControl
    {
        private GameManager _gameManager;
        public CombatScreen(GameManager gameManager)
        {
            InitializeComponent();
            _gameManager = gameManager;

            playerName.Text = _gameManager.Player.Name;
            playerAttack.Text = "Attack: " + (_gameManager.Player.CalcTotalAttackValue()).ToString();
            PlayerHealth.Text = "Health: " + (_gameManager.Player.CurrentHealth).ToString();
            playerDefense.Text= "Defense " + (_gameManager.Player.CalcTotalDefenseValue()).ToString();
            enemyName.Text = _gameManager.Enemy.Name;
            enemyAttack.Text = "Attack: " + (_gameManager.Enemy.CalcTotalAttackValue()).ToString();
            enemyHealth.Text = "Health: " + (_gameManager.Enemy.CurrentHealth).ToString();
            enemyDefense.Text = "Defense: " + (_gameManager.Enemy.CalcTotalDefenseValue()).ToString();
            depthCounter.Text = "Depth: " + _gameManager.Depth.ToString();
            goToInvetoryButton.Visible = false;
           if( _gameManager.Player.Equipped.GetItem(InventorySlotId.POTION1) == null)
            {
                potion1Button.Enabled = false;
            }
            else
            {
                potion1Button.Enabled = true;
                potion1Button.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.POTION1).ToString();
            }
            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.POTION2) == null)
            {
                potion2Button.Enabled = false;
            }
            else
            {
                potion2Button.Enabled = true;
                potion2Button.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.POTION2).ToString();
            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            
            _gameManager.performAttackPhase();
            PlayerHealth.Text = "Health: " + (_gameManager.Player.CurrentHealth).ToString();
            enemyHealth.Text = "Health: " + (_gameManager.Enemy.CurrentHealth).ToString();

            if (_gameManager.GameOver)
            {
                var endScreen = new endScreen();
                endScreen.Dock = DockStyle.Fill;
                Controls.Add(endScreen);
                combatGroupBox.Visible = false;
            }
            if (_gameManager.Enemy.IsDead)
            {
                attackButton.Enabled = false;
                goToInvetoryButton.Visible = true;
            }
            if (_gameManager.GameWon)
            {
                var endScreen = new GameWonScreen();
                endScreen.Dock = DockStyle.Fill;
                Controls.Add(endScreen);
                combatGroupBox.Visible = false;
            }
        }

        private void goToInvetoryButton_Click(object sender, EventArgs e)
        {
            var inventoryScreen = new InventoryScreen(_gameManager);
            inventoryScreen.Dock = DockStyle.Fill;
            Controls.Add(inventoryScreen);


            combatGroupBox.Visible = false;
        }

        private void potion1Button_Click(object sender, EventArgs e)
        {
            _gameManager.UsePoition(1);
            PlayerHealth.Text = "Health: " + (_gameManager.Player.CurrentHealth).ToString();
            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.POTION1) == null)
            {
                potion1Button.Enabled = false;
            }
            else
            {
                potion1Button.Enabled = true;
                potion1Button.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.POTION1).ToString();
            }
            //if (_gameManager.Player.Equipped.GetItem(InventorySlotId.POTION2) == null)
            //{
            //    potion2Button.Enabled = false;
            //}
            //else
            //{
            //    potion2Button.Enabled = true;
            //    potion2Button.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.POTION2).ToString();
            //}
        }

        private void potion2Button_Click(object sender, EventArgs e)
        {
            _gameManager.UsePoition(2);
            PlayerHealth.Text = "Health: " + (_gameManager.Player.CurrentHealth).ToString();
            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.POTION2) == null)
            {
                potion2Button.Enabled = false;
            }
            else
            {
                potion2Button.Enabled = true;
                potion2Button.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.POTION2).ToString();
            }
        }
    }
}
