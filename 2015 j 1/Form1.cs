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
    public partial class Login : Form
    {
        public static Boolean ok;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "Admin")&&(textBox2.Text == "a"))
            {
                ok=true;
                MDIParent1 i = new MDIParent1();
                i.Show();
                this.Hide();
            }
            else if((textBox1.Text == "Tur")&&(textBox2.Text == "o"))
            {
                ok=false;
                MDIParent1 i =new MDIParent1();
                i.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizatorul sau parola sunt gresite! Reincercati ;)");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
