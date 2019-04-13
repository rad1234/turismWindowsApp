using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2015_j_1
{
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
        }

       

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            if (Login.ok == false)
                adminStripMenuItem.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin newMDIChild = new Admin();
            newMDIChild.WindowState = FormWindowState.Minimized;
            newMDIChild.WindowState = FormWindowState.Maximized;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            this.Size = new Size(900, 650);
        }

        private void turistStripMenuItem_Click(object sender, EventArgs e)
        {
            Turist newMDIChild = new Turist();
            newMDIChild.WindowState = FormWindowState.Minimized;
            newMDIChild.WindowState = FormWindowState.Maximized;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            this.Size = new Size(900,400);
        }
    }
}
