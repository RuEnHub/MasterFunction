using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masterF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numericUpDown1.Value = DataBank.width;
            numericUpDown2.Value = DataBank.height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBank.width = Convert.ToInt32(numericUpDown1.Value);
            DataBank.height = Convert.ToInt32(numericUpDown2.Value);
        }
    }
}
