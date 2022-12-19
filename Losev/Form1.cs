using System.Diagnostics;
using System.Text;

namespace Losev
{
    public partial class Form1 : Form
    {
        private int[] data;

        public Form1()
        {
            InitializeComponent();
        }
        //Задание
        //Сортировка - Подсчет сравнений алгоритм С стр ~94
        //Поиск - последовательный Алгоритм S стр 429


        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            data = Sorting.Sort(data);
            stopwatch.Stop();            
            Write();
            TimeSpan ts = stopwatch.Elapsed;         
            label2.Text = $"Время выполнения \n {ts.Seconds} s, {ts.Milliseconds} ms";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog(this) == DialogResult.OK)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int temp = Searching.Find(data, form3.Temp);
                stopwatch.Stop();
                if (temp == -1)
                {
                    textBox2.Text = "Такого числа нет";
                    
                }
                else
                {
                    textBox2.Text = $"Позиция числа - {temp + 1}";
                }
                TimeSpan ts = stopwatch.Elapsed;
                label2.Text = $"Время выполнения \n {ts.Seconds} s, {ts.Milliseconds} ms ";
            }
        }

        private void generateTsButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show(this);

        }

        public void generateSet(int amount, int? lowBorder, int? highBorder)
        {
            DataSets dataSets = new DataSets();
            if (lowBorder == null && highBorder == null)
            {
                data = dataSets.GetData(amount);
            }
            else if (lowBorder == null && highBorder != null)
            {
                data = dataSets.GetData(amount, (int)highBorder);
            }
            else if (lowBorder != null && highBorder != null)
            {
                data = dataSets.GetData(amount, (int)lowBorder, (int)highBorder);
            }
            SortButton.Enabled = true;
            searchButton.Enabled = true;
            Write();
        }


        private void openTsButton_Click(object sender, EventArgs e)
        {

        }
        private void Write()
        {
            richTextBox1.Text = "";
            StringBuilder str = new StringBuilder();
            foreach (int entry in data)
            {
                str.Append($"{entry}, ");
            }
            richTextBox1.Text = str.ToString();
        }
    }
}