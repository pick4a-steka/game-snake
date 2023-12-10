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
    public partial class MainMenu : Form
    {
        string username;
        public MainMenu(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gameProcess = new Form1(this, username);
            gameProcess.Show();
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Description desc = new Description(this);
            desc.Show();
        }

        private void ChangeName_Click(object sender, EventArgs e)
        {
            this.Close();
            InputName changeName = new InputName();
            changeName.Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            // Завершаем работу программы
            Application.Exit();
        }

        private void RecordsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordsView recordsView = new RecordsView(this);
            recordsView.Show();
        }
    }
}
