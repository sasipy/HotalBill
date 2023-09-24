using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NewEntry(object sender, EventArgs e)
        {
            Food_New_Entry f = new Food_New_Entry();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sales_Billing s = new Sales_Billing();
            s.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();
        }
    }
}
