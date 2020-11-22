using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureDataAccessWindowsFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getGamesButton_Click(object sender, EventArgs e)
        {
            //gamesListBox.Items = DataAcces.GetGames();
            List<GameModel> games = new List<GameModel>();
            games = DataAcces.GetGames();
            foreach (GameModel game in games)
            {
                gamesList.Items.Add(game.ToString());
            }
        }
    }
}
