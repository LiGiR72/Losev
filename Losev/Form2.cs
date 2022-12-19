using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Losev
{
    public partial class Form2 : Form
    {
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
            int amount;
            int highBorde;
            int lowBorder;
            if(!int.TryParse(textBox1.Text,out amount))
            {
                WrongFormatError();  
            }
        }

        private void WrongFormatError()
        {
            MessageBox.Show("Введены неверные занчения", "Ошибка", MessageBoxButtons.OK);
        }
    }
}
