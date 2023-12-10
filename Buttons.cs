using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSnake
{
    public partial class Form1 : Form
    {
        private void buttonGame_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = false;
            PanelGameProcess.Visible = true;
            if (isRepeatPower)
            {
                this.timer.Start();
            }
            else InitGame();
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = false;
            Description.Visible = true;
        }

        private void backToMenu_desc_Click(object sender, EventArgs e)
        {
            Description.Visible = false;
            MainMenu.Visible = true;
        }

        private void backToMenu_records_Click(object sender, EventArgs e)
        {
            PanelRecords.Visible = false;
            MainMenu.Visible = true;
        }

        private void backToMenu_result_Click(object sender, EventArgs e)
        {
            PanelResult.Visible = false;
            PanelResult.Controls.Clear();
            MainMenu.Visible = true;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
