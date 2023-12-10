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
    public partial class Screensaver : Form
    {
        public Screensaver()
        {
            InitializeComponent();
            // Используем асинхронный метод для ожидания без блокировки главного потока
            ShowInputNameFormAsync();
            
        }

        private async void ShowInputNameFormAsync()
        {
            // Ожидаем 4 секунды без блокировки главного потока
            await Task.Delay(4000);

            // Создаем и показываем форму для записи имени
            InputName inputName = new InputName();
            this.Hide();
            inputName.Show();
        }
    }
}
