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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int Temp { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            if(!int.TryParse(textBox1.Text, out temp))
            {
                MessageBox.Show("Введено неверное занчение", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            Temp = temp;
        }
    }
}
