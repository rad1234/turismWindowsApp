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
    public partial class teapa : Form
    {
        public teapa()
        {
            InitializeComponent();
        }

        private void teapa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turismDataSet2.Porturi' table. You can move, or remove it, as needed.
            this.porturiTableAdapter.Fill(this.turismDataSet2.Porturi);

        }
    }
}
