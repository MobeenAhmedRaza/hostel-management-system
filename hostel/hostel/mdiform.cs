using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostel
{
    public partial class mdiform : Form
    {
        public mdiform()
        {
            InitializeComponent();
        }
        Form2 reg;
        private void registerStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (reg==null)
            {
             
            reg = new Form2();
            reg.MdiParent = this;
            reg.FormClosed += reg_FormClosed;
            reg.Show();   
            }
            else
            {
                reg.Activate();
            }
        }

        void reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            reg = null;
        }
        available_rooms avroom;
        private void studentBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (avroom==null)
            {
                avroom = new available_rooms();
                avroom.MdiParent = this;
                avroom.FormClosed += avroom_FormClosed;
                avroom.Show();
            }
            else
            {
                avroom.Activate();
            }
        }

        void avroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            avroom = null;
        }
        bill b;
        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b==null)
            {
                b = new bill();
                b.MdiParent = this;
                b.FormClosed += b_FormClosed;
                b.Show();
            }
            else
            {
                b.Activate();
            }
        }

        void b_FormClosed(object sender, FormClosedEventArgs e)
        {
            b = null;
        }
        info i;
        private void studentInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i==null)
            {
                i=new info();
                i.MdiParent=this;
                i.FormClosed += i_FormClosed;
                i.Show();
            }
            else
            {
                i.Activate();
            }
        }

        void i_FormClosed(object sender, FormClosedEventArgs e)
        {
            i=null;
        }
        update up;
        private void updateStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                up = new update();
                up.MdiParent = this ;
                up.FormClosed += up_FormClosed;
                up.Show();
            }
            else
            {
                up.Activate();
            }
        }

        void up_FormClosed(object sender, FormClosedEventArgs e)
        {
            up = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mdiform_Load(object sender, EventArgs e)
        {

        }
    }
}
