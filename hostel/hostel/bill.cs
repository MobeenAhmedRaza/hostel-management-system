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
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main obj = new main();
            this.Visible = false;
            obj.Visible = true;
        }
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            string i = textBox1.Text;
            string constr = "Data Source=(local);Initial Catalog=hostel;Integrated Security=True"; 
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string q = "select * from student where id='"+i+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
            string q2="select * from student where id='"+i+"'";
            con.Open();
            SqlCommand cmd1 = new SqlCommand(q2, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            string rp = "";
            if (sdr.Read())
            {
                rp = sdr[9].ToString();
            
            }
            int rp1 = 0;
            rp1 = int.Parse(rp);
            rp1 = rp1 * 5500;
            textBox2.Text = rp1.ToString() ;

        }
    }
}
