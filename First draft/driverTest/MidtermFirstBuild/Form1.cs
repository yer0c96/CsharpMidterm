using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermFirstBuild
{
    public partial class Form1 : Form
    {
        private GameManager _gameManager;
        private string playerName = "";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                playerName = "Hero";
            }
            else
            {
                playerName = nameTextBox.Text;
                
            }
            _gameManager = new GameManager(playerName);
            var inventoryScreen = new InventoryScreen(_gameManager);
            inventoryScreen.Dock = DockStyle.Fill;
            Controls.Add(inventoryScreen);


            mainMenuGroup.Visible = false;


        }
    }
}
