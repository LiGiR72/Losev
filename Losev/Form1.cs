namespace Losev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //�������
        //���������� - ������� ��������� �������� � ��� ~94
        //����� - ���������������� �������� S ��� 429
       

        private void button1_Click(object sender, EventArgs e)
        {
            Sorting.Test();
            Sorting sorting = new Sorting();
            sorting.Sort(10);
        }
    }
}