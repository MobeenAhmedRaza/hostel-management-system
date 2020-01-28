namespace hostel
{
    partial class mdiform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAvailableRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStudentToolStripMenuItem,
            this.checkAvailableRoomsToolStripMenuItem,
            this.studentBillToolStripMenuItem,
            this.studentInfoToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.studentInformationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.updateStudentToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.registerStudentToolStripMenuItem.Text = "Register Student";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // checkAvailableRoomsToolStripMenuItem
            // 
            this.checkAvailableRoomsToolStripMenuItem.Name = "checkAvailableRoomsToolStripMenuItem";
            this.checkAvailableRoomsToolStripMenuItem.Size = new System.Drawing.Size(22, 20);
            this.checkAvailableRoomsToolStripMenuItem.Text = " ";
            // 
            // studentBillToolStripMenuItem
            // 
            this.studentBillToolStripMenuItem.Name = "studentBillToolStripMenuItem";
            this.studentBillToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.studentBillToolStripMenuItem.Text = "Check Available Rooms";
            this.studentBillToolStripMenuItem.Click += new System.EventHandler(this.studentBillToolStripMenuItem_Click);
            // 
            // studentInfoToolStripMenuItem
            // 
            this.studentInfoToolStripMenuItem.Name = "studentInfoToolStripMenuItem";
            this.studentInfoToolStripMenuItem.Size = new System.Drawing.Size(22, 20);
            this.studentInfoToolStripMenuItem.Text = " ";
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.updateStudentToolStripMenuItem.Text = "Billing Information";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = " ";
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            this.studentInformationToolStripMenuItem.Click += new System.EventHandler(this.studentInformationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = " ";
            // 
            // updateStudentToolStripMenuItem1
            // 
            this.updateStudentToolStripMenuItem1.Name = "updateStudentToolStripMenuItem1";
            this.updateStudentToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.updateStudentToolStripMenuItem1.Text = "Update Student";
            this.updateStudentToolStripMenuItem1.Click += new System.EventHandler(this.updateStudentToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem3.Text = " ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mdiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 384);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdiform";
            this.Text = "mdiform";
            this.Load += new System.EventHandler(this.mdiform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAvailableRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;


    }
}