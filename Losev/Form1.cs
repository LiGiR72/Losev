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

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void generateTsButton_Click(object sender, EventArgs e)
        {
            //DataSets dataSet = new DataSets();
            //int amount;
            //data = dataSet.GetData();
            Form2 newForm = new Form2();
            //if (newForm.ShowDialog(this) == DialogResult.OK)
            //{

            //}
            //else
            //{

            //}
            newForm.Show();

        }

        public void generateSet(int amount)
        {
            DataSets dataSets = new DataSets();
            data = dataSets.GetData(amount);
        }
        public void generateSet(int amount, int maxBorder)
        {
            DataSets dataSets = new DataSets();
            data = dataSets.GetData(amount, maxBorder);

        }
        public void generateSet(int amount, int minBorder, int maxBorder)
        {
            DataSets dataSets = new DataSets();
            data = dataSets.GetData(amount, minBorder, maxBorder);

        }
    }
}