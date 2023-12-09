using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSnake
{
    public partial class Form1 : Form
    {
        // ПЕРЕМЕННЫЕ =============================================================
        private static int WIDTH = 600; // дефолтные параметры окна
        private static int HEIGHT = 600; // дефолтные параматеры окна
        private static int sizeOneFields; // поле для размера клетки на карте
        //private System.Windows.Forms.Label lableScore;
        private List<PictureBox> snake_array = new List<PictureBox>(400);
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        Apple apple;
        Banana banana;
        Pear pear;
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        CounterApple cntApple;
        CounterBanana cntBanana;
        CounterPear cntPear;
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private int dirX, dirY;
        private Image currImage;
        private Timer timer;
        private int score = 0;
        private bool isPause = false;
        private System.Windows.Forms.Label textPause;
        // =========================================================================

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = WIDTH;
            this.Height = HEIGHT;
            sizeOneFields = 19;
            //lableScore = new System.Windows.Forms.Label();
            //lableScore.Text = "Score: 0";
            //lableScore.Location = new Point(30, 30);
            //this.Controls.Add(lableScore);
            snake_array.Add(new PictureBox());
            snake_array[0].Location = new Point(380, 285);
            snake_array[0].Size = new Size(sizeOneFields, sizeOneFields);
            // Инициализация изображений заранее
            currImage = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\snake-head1.png");
            snake_array[0].Image = currImage;
            this.Controls.Add(snake_array[0]);
            dirX = 0; dirY = -1;
            InitializeTimer();
            InitializeFruits();
            InitCounters();
            geterationMap();
            this.KeyDown += new KeyEventHandler(Move);
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 200; // Интервал таймера в миллисикундах
            timer.Tick += new EventHandler(update); // Метод, вызываемый при срабатывании таймера
            timer.Start();
        }
        private void textPause_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, textPause.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void InitializeTextMenu()
        {
            // Настройка текста и его внешнего вида
            textPause = new System.Windows.Forms.Label();
            textPause.Text = "Игра на паузе";
            textPause.Font = new Font(FontFamily.GenericMonospace, 14, FontStyle.Bold);
            textPause.ForeColor = Color.Red;
            textPause.Size = new Size(155, 30);
            textPause.Location = new Point((int)(WIDTH / 3), (int)(HEIGHT / 2.5));
            textPause.BackColor = Color.Green;
            textPause.Paint += new PaintEventHandler(textPause_Paint);
            this.Controls.Add(textPause);
            // Перемещаем надпись в передний план
            textPause.BringToFront();
        }
        private bool checkBorder()
        {
            if (snake_array[0].Location.X < 0 || snake_array[0].Location.X > WIDTH - 11 || snake_array[0].Location.Y > HEIGHT - 2 * sizeOneFields - 12 ||
                snake_array[0].Location.Y < 95)
            {
                return true;
            }
            return false;
        }

        private bool eatSelf()
        {
            for (int i = score; i >= 1; --i)
            {
                if (snake_array[0].Location == snake_array[i].Location)
                {
                    return true;
                }
            }
            return false;
        }

        private void eatFruits()
        {
            if ((snake_array[0].Location.X == apple.pX && snake_array[0].Location.Y == apple.pY) ||
                (snake_array[0].Location.X == banana.pX && snake_array[0].Location.Y == banana.pY) ||
                (snake_array[0].Location.X == pear.pX && snake_array[0].Location.Y == pear.pY))
            {
                //lableScore.Text = "Score: " + ++score;
                ++score;
                if (snake_array[0].Location.X == apple.pX && snake_array[0].Location.Y == apple.pY)
                {
                    cntApple.cnt++;
                    cntApple.count.Text = "" + cntApple.cnt;
                }
                else if (snake_array[0].Location.X == banana.pX && snake_array[0].Location.Y == banana.pY)
                {
                    cntBanana.cnt++;
                    cntBanana.count.Text = "" + cntBanana.cnt;
                }
                else
                {
                    cntPear.cnt++;
                    cntPear.count.Text = "" + cntPear.cnt;
                }
                PictureBox new_segment = new PictureBox();
                new_segment.Location = new Point(snake_array[score - 1].Location.X + sizeOneFields * dirX, snake_array[score - 1].Location.Y - sizeOneFields * dirY);
                new_segment.Size = new Size(sizeOneFields, sizeOneFields);
                new_segment.BackColor = Color.Green;
                snake_array.Add(new_segment);
                this.Controls.Add(snake_array[score]);
                InitializeFruits();
            }
        }

        private void moveSnake()
        {
            for (int i = score; i >= 1; --i)
            {
                snake_array[i].Location = snake_array[i - 1].Location;
            }
            snake_array[0].Location = new Point(snake_array[0].Location.X + dirX * sizeOneFields, snake_array[0].Location.Y + dirY * sizeOneFields);
        }

        private void update(Object myObject, EventArgs eventArgs)
        {
            Console.WriteLine($"Score = {score}");
            eatFruits();
            moveSnake();
            if (score > 25) timer.Interval = 100;
            else if (score > 40) timer.Interval = 80;
            if (eatSelf() || checkBorder()) this.Close();

            if (currImage != null)
            {
                currImage.Dispose();
            }

            if (dirX == 1) currImage = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\snake-head-D.png");
            else if (dirX == -1) currImage = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\snake-head-A.png");
            else if (dirY == 1) currImage = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\snake-head-S.png");
            else if (dirY == -1) currImage = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\snake-head1.png");

            snake_array[0].Image = currImage;

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Рисуем вертикальные линии
            for (int i = 0; i <= WIDTH + 1; i += sizeOneFields)
            {
                g.DrawLine(Pens.Black, i, 95, i, HEIGHT - 2 * sizeOneFields - 11);
            }

            // Рисуем горизонтальные линии
            for (int i = 95; i <= HEIGHT - 2 * sizeOneFields - 11; i += sizeOneFields)
            {
                g.DrawLine(Pens.Black, 0, i, WIDTH - 11, i);
            }

           if (currImage != null)
                g.DrawImage(currImage, snake_array[0].Location);
        }

        private void geterationMap()
        { // Создаем карту игры
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void Move(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "D":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "A":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "W":
                    dirY = -1;
                    dirX = 0;
                    break;
                case "S":
                    dirY = 1;
                    dirX = 0;
                    break;
                case "Escape":
                    isPause = !isPause;
                    if (isPause)
                    {
                        timer.Stop();
                        InitializeTextMenu();
                    }
                    else
                    {
                        timer.Start();
                        this.Controls.Remove(textPause);
                    }
                    break;
            }
        }

        private void snake_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка изображений для каждого направления
            // Image imgA = Image.FromFile("im/snake-head-A.png");
            // Image imgD = Image.FromFile("im/snake-head-D.png");
            // Image imgW = Image.FromFile("C:\\Users\\kmiha\\OneDrive\\Рабочий стол\\work\\Game_on_C#\\KSnake\\im\\snake-head1.png");
            // Image imgS = Image.FromFile("im/snake-head-S.png");

            // currImage = imgW; // начальное изображение

            // Освобождение ресурсов
            // imgA.Dispose();
            // imgD.Dispose();
            // imgW.Dispose();
            // imgS.Dispose();
        }
    }
}
