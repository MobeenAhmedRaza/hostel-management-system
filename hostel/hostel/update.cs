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
using System.Configuration;

namespace hostel
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Visible = false;
            m.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        DataSet ds = new DataSet();
        private void update_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=(local);Initial Catalog=hostel;Integrated Security=True"; 
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string q = "select * from student";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];

            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string constr = "Data Source=(local);Initial Catalog=hostel;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {


                string q = "update student set name='" + txtname.Text + "',religion='" + txtrel.Text + "',nationality='" + txtnat.Text + "',contact='" + txtcon.Text + "',gender='" + txtgen.Text + "',email='" + txtmail.Text + "',rental='" + txtren.Text + "' where id='" + txtid.Text + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string constr = "Data Source=(local);Initial Catalog=hostel;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {


                string q = "delete from student where id='" + txtid.Text + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
        }
    }
}
