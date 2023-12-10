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
    public partial class Description : Form
    {
        MainMenu mainMenu;
        public Description(MainMenu menu)
        {
            InitializeComponent();
            this.mainMenu = menu;
        }

        private void backToMenu_desc_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu.Show();
        }
    }
}
