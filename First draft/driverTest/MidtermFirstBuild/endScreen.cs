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
    public partial class endScreen : UserControl
    {
        private GameManager _gameManager;
        public endScreen()
        {
            InitializeComponent();
            _gameManager = new GameManager("Hero");
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            var inventoryScreen = new InventoryScreen(_gameManager);
            inventoryScreen.Dock = DockStyle.Fill;
            Controls.Add(inventoryScreen);


            endScreenGroupBox.Visible = false;
        }
    }
}
