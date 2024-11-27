using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KSnake
{
    public partial class Form1 : Form
    {
        public abstract class CounterBase : IObject
        {
            public PictureBox pictureBox { get; set; }
            public int pX { get; set; }
            public int pY { get; set; }
            
            public Label count = new Label();
            public int cnt = 0;

            public CounterBase(int width, int height, int sof)
            {
                Form1.WIDTH = width;
                Form1.HEIGHT = height;
                Form1.sizeOneFields = sof;
            }

            protected abstract void InitializeCounter();
        }

        public class CounterApple : CounterBase
        {
            public CounterApple(int width, int height, int sof) : base(width, height, sof)
            {
                InitializeCounter();
            }

            protected override void InitializeCounter()
            {
                pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\apple.png");
                pictureBox.BackColor = Color.FromArgb(172, 192, 104);
                pX = WIDTH / 20; pY = HEIGHT / 20;
                pictureBox.Location = new Point(pX, pY);
                pictureBox.Size = new Size(Form1.sizeOneFields, Form1.sizeOneFields);
                count.Location = new Point(pX + Form1.sizeOneFields, pY);
                count.BackColor = Color.FromArgb(172, 192, 104);
                count.Size = new Size(Form1.sizeOneFields, Form1.sizeOneFields);
                count.Text = cnt.ToString();
            }
        }

        public class CounterBanana : CounterBase
        {
            public CounterBanana(int width, int height, int sof) : base(width, height, sof)
            {
                InitializeCounter();
            }

            protected override void InitializeCounter()
            {
                pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\banana.png");
                pictureBox.BackColor = Color.FromArgb(172, 192, 104);
                pX = WIDTH / 20 + 5 * Form1.sizeOneFields; pY = HEIGHT / 20;
                pictureBox.Location = new Point(pX, pY);
                pictureBox.Size = new Size(Form1.sizeOneFields, Form1.sizeOneFields);
                count.Location = new Point(pX + Form1.sizeOneFields, pY);
                count.BackColor = Color.FromArgb(172, 192, 104);
                count.Size = new Size(Form1.sizeOneFields, Form1.sizeOneFields);
                count.Text = cnt.ToString();
            }
        }

        public class CounterPear : CounterBase
        {
            public CounterPear(int width, int height, int sof) : base(width, height, sof)
            {
                InitializeCounter();
            }

            protected override void InitializeCounter()
            {
                pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\pear.png");
                pictureBox.BackColor = Color.FromArgb(172, 192, 104);
                pX = WIDTH / 20 + 10 * Form1.sizeOneFields; pY = HEIGHT / 20;
                pictureBox.Location = new Point(pX, pY);
                pictureBox.Size = new Size(Form1.sizeOneFields, Form1.sizeOneFields);
                count.Location = new Point(pX + Form1.sizeOneFields, pY);
                count.BackColor = Color.FromArgb(172, 192, 104);
                count.Size = new Size(Form1.sizeOneFields, Form1.sizeOneFields);
                count.Text = cnt.ToString();
            }
        }

        private void InitCounters()
        {
            // Создаём экземпляры счетчиков фруктов
            cntApple = new CounterApple(WIDTH, HEIGHT, sizeOneFields);
            cntBanana = new CounterBanana(WIDTH, HEIGHT, sizeOneFields);
            cntPear = new CounterPear(WIDTH, HEIGHT, sizeOneFields);

            // Добавляем счётчики на форму
            this.Controls.Add(cntApple.pictureBox);
            this.Controls.Add(cntApple.count);
            this.Controls.Add(cntBanana.pictureBox);
            this.Controls.Add(cntBanana.count);
            this.Controls.Add(cntPear.pictureBox);
            this.Controls.Add(cntPear.count);
        }
    }
}
