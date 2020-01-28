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
    public partial class available_rooms : Form
    {
        public available_rooms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataSet ds = new DataSet();
        private void available_rooms_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=(local);Initial Catalog=hostel;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string q = "select * from room where status='Available'";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main i = new main();
            this.Visible = false;
            i.Visible = true;
        }
    }
}
