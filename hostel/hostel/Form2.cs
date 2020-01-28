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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=(local);Initial Catalog=hostel;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                
            
            string q = "insert into student values('"+txtid.Text+"','"+txtname.Text+"','"+txtrel.Text+"','"+txtnat.Text+"','"+txtdob.Text+"','"+txtcon.Text+"','"+txtgen.Text+"','"+DateTime.Now+"','"+txtmail.Text+"','"+txtren.Text+"')";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
            con.Close();

            txtid.Text = "";
            txtname.Text = "";
            txtdob.Text = "";
            txtnat.Text = "";
            txtrel.Text = "";
            txtgen.Text = "";
            txtmail.Text = "";
            txtren.Text = "";
            comboBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            mdiform m = new mdiform();
            this.Visible = false;
            m.Visible = true;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
