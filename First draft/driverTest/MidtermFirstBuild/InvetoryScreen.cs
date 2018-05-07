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
    public partial class InventoryScreen : UserControl
    {
        private GameManager _gameManager;
        public InventoryScreen(GameManager gameManager)
        {
            InitializeComponent();
            _gameManager = gameManager;

            // FIXME: check for null enemy
            if (_gameManager.Enemy.IsDead)
            {
                _gameManager.Enemy.UnequipAll();
                for (int x = 0; x < _gameManager.Enemy.Bag.Count; ++x)
                {
                    lootBox.Items.Add(_gameManager.Enemy.Bag.GetItem(x));
                }
            }
            for (int x = 0; x < _gameManager.Player.Bag.Count; ++x)
            {
                bagBox.Items.Add(_gameManager.Player.Bag.GetItem(x));
            }
            bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
            addToBagButton.Enabled = false;
            removeButton.Enabled = false;
            equipButton.Enabled = false;

            changeButtons();

            attackLabel.Text = "Attack: " + (_gameManager.Player.CalcTotalAttackValue()).ToString();
            defenseLabel.Text = "Defense " + (_gameManager.Player.CalcTotalDefenseValue()).ToString();
            disableButtons();
        }

        private void nextButtonButton_Click(object sender, EventArgs e)
        {
            _gameManager.GenerateNewEnemy();
            var combatScreen = new CombatScreen(_gameManager);
            combatScreen.Dock = DockStyle.Fill;
            Controls.Add(combatScreen);


            inventoryGroupBox.Visible = false;
            
        }

        private void addToBagButton_Click(object sender, EventArgs e)
        {
            try
            {
                // FIXME: check for no item selected
                _gameManager.Player.Pickup((Item)lootBox.SelectedItem);
                if (_gameManager.Player.Bag.Count < _gameManager.Player.Bag.Capacity)
                {

                    _gameManager.Enemy.Bag.RemoveItem((Item)lootBox.SelectedItem);
                    lootBox.Items.Remove(lootBox.SelectedItem);
                    bagBox.Items.Add(_gameManager.Player.Bag.GetItem(_gameManager.Player.Bag.Count - 1));
                    bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
                }
            }catch (BagFullException ex)
            {
                exceptionLabel.Text = ex.Message;
            }
            disableButtons();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // FIXME: check for no item selected
            // FIXME: check if enemy bag is full
            lootBox.Items.Add((Item)bagBox.SelectedItem);
            _gameManager.Enemy.Bag.AddItem((Item)bagBox.SelectedItem);
            _gameManager.Player.Bag.RemoveItem((Item)bagBox.SelectedItem);
            bagBox.Items.Remove(bagBox.SelectedItem);
                
                
                
            bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
        }

        private void lootBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lootBox.SelectedIndex >= 0)
            {
                addToBagButton.Enabled = true;
            }
            if(lootBox.Items.Count <= 0)
            {
                addToBagButton.Enabled = false;
            }
        }

        private void bagBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bagBox.SelectedIndex >= 0 && bagBox.Items.Count > 0)
            {
                removeButton.Enabled = true;
                equipButton.Enabled = true;
            }
            if (bagBox.Items.Count <= 0)
            {
                removeButton.Enabled = false;
                equipButton.Enabled = false;
            }
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            int itemIndex = bagBox.SelectedIndex;
            Item oldItem = _gameManager.Player.Equipped.Equip(((Item)bagBox.SelectedItem).Slot, (Item)bagBox.SelectedItem);
            _gameManager.Player.Bag.RemoveItem((Item)bagBox.SelectedItem);
            if(oldItem != null)
            {
                // FIXME: call AddItem() instead
                _gameManager.Player.Bag.SetItem(itemIndex, oldItem);
                bagBox.Items.Add(oldItem);
            }
            bagBox.Items.Clear();
            for (int x = 0; x < _gameManager.Player.Bag.Count; ++x)
            {
                bagBox.Items.Add(_gameManager.Player.Bag.GetItem(x));
            }
            bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
            changeButtons();
            attackLabel.Text = "Attack: " + (_gameManager.Player.CalcTotalAttackValue()).ToString();
            defenseLabel.Text = "Defense " + (_gameManager.Player.CalcTotalDefenseValue()).ToString();
            if (bagBox.SelectedIndex >= 0 && bagBox.Items.Count > 0)
            {
                removeButton.Enabled = true;
                equipButton.Enabled = true;
            }
            if (bagBox.Items.Count <= 0 || bagBox.SelectedIndex < 0)
            {
                removeButton.Enabled = false;
                equipButton.Enabled = false;
            }
        }


        private void changeButtons()
        {
            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.HELMET) != null)
            {
                headButton.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.HELMET).ToString();
            }
            else
            {
                headButton.Text = "None";
            }

            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.WEAPON) != null)
            {
                weaponButton.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.WEAPON).ToString();
            }
            else
            {
                weaponButton.Text = "None";
            }

            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.CHESTPIECE) != null)
            {
                bodyButton.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.CHESTPIECE).ToString();
            }
            else
            {
                bodyButton.Text = "None";
            }

            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.VAMBRACES) != null)
            {
                armsButton.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.VAMBRACES).ToString();
            }
            else
            {
                armsButton.Text = "None";
            }

            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.POTION1) != null)
            {
                potion1Button.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.POTION1).ToString();
            }
            else
            {
                potion1Button.Text = "None";
            }

            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.GREAVES) != null)
            {
                legsButton.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.GREAVES).ToString();
            }
            else
            {
                legsButton.Text = "None";
            }

            if (_gameManager.Player.Equipped.GetItem(InventorySlotId.POTION2) != null)
            {
                potion2Button.Text = _gameManager.Player.Equipped.GetItem(InventorySlotId.POTION2).ToString();
            }
            else
            {
                potion2Button.Text = "None";
            }

            attackLabel.Text = "Attack: " + (_gameManager.Player.CalcTotalAttackValue()).ToString();
            defenseLabel.Text = "Defense " + (_gameManager.Player.CalcTotalDefenseValue()).ToString();
            disableButtons();
        }

        private void headButton_Click(object sender, EventArgs e)
        {
                if (_gameManager.Player.Bag.Count < _gameManager.Player.Bag.Capacity)
                {
                    Item unequippedItem = _gameManager.Player.Equipped.Unequip(InventorySlotId.HELMET);
                    if (unequippedItem != null)
                    {
                        _gameManager.Player.Pickup(unequippedItem);
                        bagBox.Items.Add(unequippedItem);
                        bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
                        changeButtons();
                    }
                }
            disableButtons();
        }

        private void weaponButton_Click(object sender, EventArgs e)
        {
                Item unequippedItem = _gameManager.Player.Equipped.Unequip(InventorySlotId.WEAPON);
                if (unequippedItem != null)
                {
                    _gameManager.Player.Pickup(unequippedItem);
                    bagBox.Items.Add(unequippedItem);
                    bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
                    changeButtons();
                }
            disableButtons();
        }

        private void bodyButton_Click(object sender, EventArgs e)
        {
                Item unequippedItem = _gameManager.Player.Equipped.Unequip(InventorySlotId.CHESTPIECE);
                if (unequippedItem != null)
                {
                    _gameManager.Player.Pickup(unequippedItem);
                    bagBox.Items.Add(unequippedItem);
                    bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
                    changeButtons();
                }
            disableButtons();
        }

        private void armsButton_Click(object sender, EventArgs e)
        {
                Item unequippedItem = _gameManager.Player.Equipped.Unequip(InventorySlotId.VAMBRACES);
                if (unequippedItem != null)
                {
                    _gameManager.Player.Pickup(unequippedItem);
                    bagBox.Items.Add(unequippedItem);
                    bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
                    changeButtons();
                }
            disableButtons();
        }

        private void potion1Button_Click(object sender, EventArgs e)
        {
                Item unequippedItem = _gameManager.Player.Equipped.Unequip(InventorySlotId.POTION1);
                if (unequippedItem != null)
                {
                    _gameManager.Player.Pickup(unequippedItem);
                    bagBox.Items.Add(unequippedItem);
                    bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
                    changeButtons();
                }
            disableButtons();
        }

        private void legsButton_Click(object sender, EventArgs e)
        {
                Item unequippedItem = _gameManager.Player.Equipped.Unequip(InventorySlotId.GREAVES);
                if (unequippedItem != null)
                {
                    _gameManager.Player.Pickup(unequippedItem);
                    bagBox.Items.Add(unequippedItem);
                    bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
                    changeButtons();
                }
            disableButtons();
        }

        private void potion2Button_Click(object sender, EventArgs e)
        {
                Item unequippedItem = _gameManager.Player.Equipped.Unequip(InventorySlotId.POTION2);
                if (unequippedItem != null)
                {
                    _gameManager.Player.Pickup(unequippedItem);
                    bagBox.Items.Add(unequippedItem);
                    bagCountLabel.Text = String.Format("{0}/20 items", _gameManager.Player.Bag.Count);
                    changeButtons();
                }
            disableButtons();
        }

        public void disableButtons()
        {
            if (_gameManager.Player.Bag.Count == _gameManager.Player.Bag.Capacity)
            {
                headButton.Enabled = false;
                weaponButton.Enabled = false;
                bodyButton.Enabled = false;
                armsButton.Enabled = false;
                potion1Button.Enabled = false;
                legsButton.Enabled = false;
                potion2Button.Enabled = false;
            }
            else
            {
                headButton.Enabled = true;
                weaponButton.Enabled = true;
                bodyButton.Enabled = true;
                armsButton.Enabled = true;
                potion1Button.Enabled = true;
                legsButton.Enabled = true;
                potion2Button.Enabled = true;
            }
        }
    }
}
