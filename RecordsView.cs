using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSnake
{
    public partial class RecordsView : Form
    {
        private struct Records
        {
            public string name;
            public int cntApple;
            public int cntBanana;
            public int cntPear;
            public int all;
        }
        string filename = "game_result.dat";
        string txtfile = "records.txt";
        List<Records> records = new List<Records>();
        MainMenu menu;
        public RecordsView(MainMenu menu)
        {
            InitializeComponent();
            ReadBinFileRecords();
            SortByBetterResult();
            WriteRecordsInForm();
            this.menu = menu;
        }

        private void ReadBinFileRecords()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    Records rec = new Records();
                    rec.name = reader.ReadString();
                    rec.cntApple = reader.ReadInt32();
                    rec.cntBanana = reader.ReadInt32();
                    rec.cntPear = reader.ReadInt32();
                    rec.all = reader.ReadInt32();

                    records.Add(rec);
                }
            }
        }

        private void SortByBetterResult()
        { // использует LINQ-метод OrderByDescending, чтобы отсортировать элементы списка
            records = records.OrderByDescending(x => x.all).ToList();
        }

        private void WriteRecordsInForm()
        {
            for (int i = 0; i < 10 && i < records.Count; i++)
            {
                ListNameRecords.Text += records[i].name + '\n';
                ListRecords.Text +=  records[i].cntApple + "         " + records[i].cntBanana + "        " + records[i].cntPear + "\n";
            }
        }

        private void backToMenu_records_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Show();
        }

        private void DeleteRecords_Click(object sender, EventArgs e)
        {
            // Перезаписываем файл с пустым содержимым
            File.WriteAllText(filename, string.Empty);

            // Очищаем список записей
            records.Clear();
        }

        private void ConvertTotxt_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(txtfile))
            {
                foreach (var rec in records)
                {
                    writer.WriteLine($"{rec.name}\t{rec.cntApple}\t{rec.cntBanana}\t{rec.cntPear}\n");
                }
            }
        }
    }
}
