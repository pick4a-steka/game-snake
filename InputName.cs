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
    public partial class InputName : Form
    {
        private const int MaxNameLength = 10; // Максимальная длина имени
        public InputName()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // Получаем введенное имя пользователя
            string username = inputUser.Text.Trim(); // Удаляем пробелы в начале и конце

            if (string.IsNullOrEmpty(username)) return;
            if (username.Length > MaxNameLength) return;

            // Создаем новую форму меню
            MainMenu menuForm = new MainMenu(username);

            // Показываем новую форму
            menuForm.Show();

            // Закрываем текущую форму
            this.Close();
        }
    }
}
