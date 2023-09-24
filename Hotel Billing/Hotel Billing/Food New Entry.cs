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
    public partial class Food_New_Entry : Form
    {
        public Food_New_Entry()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=(localdb)\v11.0; initial catalog=HotelDB; 
        integrated security=true");

        private void submit(object sender, EventArgs e)
        {
            con.Open();
            char t=' ';
            if(rveg.Checked)
            {
                t='V';
            }
            else
            {
                t='N';
            }
            SqlCommand cmd=new SqlCommand("insert into Food values('"+tname.Text+"','"+t+"',"+tprice.Text+",'"+
                cavailability.Text+"')",con);
            int i=cmd.ExecuteNonQuery();
            SqlCommand cmd1=new SqlCommand("select Fid from Food where Fname='"+tname.Text+"'",con);
            String name=Convert.ToString( cmd1.ExecuteScalar());
            MessageBox.Show(i+" records inserted & Food id is "+name);
            con.Close();
        }

        private void delete(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Food where Fname='" + dataGridView1.CurrentCell.Value + "'", con);
            int i=cmd.ExecuteNonQuery();
            MessageBox.Show(i+" Food deleted");
            con.Close();
        }

        private void view(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Food where Fname='" + dataGridView1.CurrentCell.Value
                + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                tname.Text = dr["Fname"].ToString();
                tprice.Text = Convert.ToString( dr[3]);
                cavailability.Text = dr["Favailable"].ToString();
                if(Convert.ToChar( dr["Ftype"])=='V')
                {
                    rveg.Checked=true;
                }
                else
                {
                    rnonveg.Checked=true;
                }
            }
            else
            {
                MessageBox.Show("No Records Found");
            }
            con.Close();
        }

        private void update(object sender, EventArgs e)
        {
            con.Open();
            char t=' ';
            if(rveg.Checked)
            {
                t='V';
            }
            else
            {
                t='N';
            }
            SqlCommand cmd = new SqlCommand("update Food set Fname='" + tname.Text + "',Ftype='" + t + "',Fprice=" + tprice.Text
                + ",Favailable='" + cavailability.Text + "' where Fname='"+dataGridView1.CurrentCell.Value+"'", con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show(i+" Records Updated");
            con.Close();
        }

    }
}
