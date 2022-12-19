namespace Losev
{
    public partial class Form2 : Form
    {
        public int Amount { get; set; }
        public int? HighBorder { get; set; } = null;
        public int? LowBorder { get; set; } = null;
        public Form2()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            panel3.Enabled = false;
            panel3.Visible = false;
            panel4.Enabled = false;
            panel4.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            panel3.Enabled = true;
            panel3.Visible = true;
            panel4.Enabled = false;
            panel4.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            panel3.Visible = true;
            panel4.Enabled = true;
            panel4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = 0;
            int highBorder = 0;
            int lowBorder = 0;
            Amount = 0;
            LowBorder = null;
            HighBorder = null;
            if (!int.TryParse(textBox1.Text, out amount))
            {
                WrongFormatError();
                return;
            }
            if (panel3.Enabled == true)
            {
                if (!int.TryParse(textBox2.Text, out highBorder))
                {
                    WrongFormatError();
                    return;
                }
                HighBorder = highBorder;
            }
            if (panel4.Enabled == true)
            {
                if (!int.TryParse(textBox3.Text, out lowBorder))
                {
                    WrongFormatError();
                    return;
                }
                if (lowBorder > highBorder)
                    MessageBox.Show("Введены неверные границы", "Ошибка", MessageBoxButtons.OK);
                LowBorder = lowBorder;
            }
            Amount = amount;
            Form1 form = (Form1)this.Owner;
            form.generateSet(Amount, LowBorder, HighBorder);
            this.Close();
        }

        private void WrongFormatError()
        {
            MessageBox.Show("Введены неверные занчения", "Ошибка", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
