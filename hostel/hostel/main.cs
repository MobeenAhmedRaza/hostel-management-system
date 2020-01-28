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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Visible = false;
            f.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            info i = new info();
            this.Visible = false;
            i.Visible = true;
        }
        DataSet ds = new DataSet();
        private void button2_Click(object sender, EventArgs e)
        {
            available_rooms a = new available_rooms();
            this.Visible = false;
            a.Visible = true;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            update u=new update();
            this.Visible = false;
            u.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bill b = new bill();
            this.Visible = false;
            b.Visible = true;
        }
    }
}
