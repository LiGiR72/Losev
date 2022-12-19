namespace Losev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Задание
        //Сортировка - Подсчет сравнений алгоритм С стр ~94
        //Поиск - последовательный Алгоритм S стр 429
       

        private void button1_Click(object sender, EventArgs e)
        {
            Sorting.Test();
            Sorting sorting = new Sorting();
            sorting.Sort(10);
        }
    }
}