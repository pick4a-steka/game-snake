using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSnake
{
    public partial class ResultGame : Form
    {
        MainMenu mainMenu;
        public ResultGame(int cntApple, int cntBanana, int cntPear, MainMenu menu, string name)
        {
            InitializeComponent();
            this.countApple.Text = "" + cntApple;
            this.countBanana.Text = "" + cntBanana;
            this.countPear.Text = "" + cntPear;
            this.NameLabel.Text = "ИМЯ: " + name;
            this.mainMenu = menu;
        }

        private void backToMenu_result_Click(object sender, EventArgs e)
        {
            mainMenu.Show();
            this.Close();
        }
    }
}
