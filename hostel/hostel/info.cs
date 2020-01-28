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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataSet ds = new DataSet();
        private void info_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Visible = false;
            m.Visible = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
