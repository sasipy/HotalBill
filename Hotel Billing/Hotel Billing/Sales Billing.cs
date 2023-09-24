using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Billing
{
    public partial class Sales_Billing : Form
    {
        public Sales_Billing()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"data source=(localdb)\v11.0; initial catalog=HotelDB; 
        integrated security=true");

        private void Bill_Load(object sender, EventArgs e)
        {
            conn.Open();
            Random r = new Random();
            textBox1.Text = r.Next(1000,9999).ToString();
            SqlCommand cmd = new SqlCommand("select Fid,Fname from Food", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Fname";
            comboBox1.ValueMember = "Fid";
            SqlCommand cmd1 = new SqlCommand("select Fprice from Food where Fid=" + comboBox1.SelectedValue + "", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["Fprice"].ToString();
                textBox3.Text = "1";
                textBox4.Text = dr["Fprice"].ToString();
            }
            else
            {
                MessageBox.Show("No Records Found!");
            }
            conn.Close();
        }

        private void Food(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Fprice from Food where Fid="+comboBox1.SelectedValue+"",conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox2.Text = dr["Fprice"].ToString();
                textBox3.Text = "1";
                textBox4.Text = dr["Fprice"].ToString();

            }
            else
            {
                MessageBox.Show("No Records Found!");
            }
            conn.Close();
        }

        private void add(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Billing (BillNo,Fid,Price,Quantity,Amount) values(" +
                textBox1.Text+","+comboBox1.SelectedValue+","+textBox2.Text+","+textBox3.Text+","+textBox4.Text
                +")",conn);
            int i = cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("select * from Billing where BillNo="+textBox1.Text+" ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand cmd2 = new SqlCommand("select sum(Amount) from Billing where BillNo=" + textBox1.Text + "", 
                conn);
            textBox5.Text = Convert.ToString(cmd2.ExecuteScalar());
            MessageBox.Show(i + " Food adding");
            conn.Close();
        }

        private void Quantity(object sender, EventArgs e)
        {
            double price =double.Parse( textBox2.Text);
            double quan;
            if(string.IsNullOrWhiteSpace( textBox3.Text))
            {
                quan = 1;
            }
            else 
            { 
            quan = double.Parse(textBox3.Text);
             }
            double amount = price * quan;
            textBox4.Text = amount.ToString();
        }

        
    }
}
