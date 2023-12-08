using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSnake
{
    public partial class Form1 : Form
    {
        public interface IObject
        {
            PictureBox pictureBox { get; set; }
            int pX { get; set; }
            int pY { get; set; }
        }

        public abstract class FruitBase : IObject
        {
            private static Random random = new Random();
            public PictureBox pictureBox { get; set; }
            public int pX { get; set; }
            public int pY { get; set; }

            protected FruitBase(int width, int height, int sof)
            {
                Form1.WIDTH = width;
                Form1.HEIGHT = height;
                Form1.sizeOneFields = sof;
                generateFruit();
            }

            protected abstract void InitializePictureBox();

            private void generateFruit()
            {
                //Random r = new Random();
                pictureBox = new PictureBox();
                pX = random.Next(0, WIDTH - 11);
                int tmpX = pX % sizeOneFields;
                pX -= tmpX;
                pY = random.Next(95, HEIGHT - 2 * sizeOneFields - 11);
                int tmpY = pY % sizeOneFields;
                pY -= tmpY;
                pictureBox.Location = new Point(pX+1, pY+1);
            }
        }

        public class Apple : FruitBase
        {
            public Apple(int width, int height, int sof) : base(width, height, sof)
            {
                InitializePictureBox();
            }
            protected override void InitializePictureBox()
            {
                pictureBox.Image = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\apple.png");
                pictureBox.Size = new Size(Form1.sizeOneFields-1, Form1.sizeOneFields-1);
            }
        }

        public class Banana : FruitBase
        {
            public Banana(int width, int height, int sof) : base(width, height, sof)
            {
                InitializePictureBox();
            }
            protected override void InitializePictureBox()
            {
                pictureBox.Image = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\banana.png");
                pictureBox.Size = new Size(Form1.sizeOneFields-1, Form1.sizeOneFields-1);
            }
        }

        public class Pear : FruitBase
        {
            public Pear(int width, int height, int sof) : base(width, height, sof)
            {
                InitializePictureBox();
            }
            protected override void InitializePictureBox()
            {
                pictureBox.Image = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\pear.png");
                pictureBox.Size = new Size(Form1.sizeOneFields-1, Form1.sizeOneFields-1);
            }
        }

        private void InitializeFruits()
        {
            if (apple != null && banana != null && pear != null)
            { // Удаляем старые фрукты и их PictureBox
                this.Controls.Remove(apple.pictureBox);
                this.Controls.Remove(banana.pictureBox);
                this.Controls.Remove(pear.pictureBox);
            }

            // Создаем экземпляры фруктов
            apple = new Apple(WIDTH, HEIGHT, sizeOneFields);
            banana = new Banana(WIDTH, HEIGHT, sizeOneFields);
            pear = new Pear(WIDTH, HEIGHT, sizeOneFields);

            Console.WriteLine($"Apple: X={apple.pX}, Y={apple.pY}");
            Console.WriteLine($"Banana: X={banana.pX}, Y={banana.pY}");
            Console.WriteLine($"Pear: X={pear.pX}, Y={pear.pY}");

            // Добавляем PictureBox на форму
            this.Controls.Add(apple.pictureBox);
            this.Controls.Add(banana.pictureBox);
            this.Controls.Add(pear.pictureBox);
        }
    }
}
