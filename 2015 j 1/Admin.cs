using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace _2015_j_1
{
    public partial class Admin : Form
    {
        int t = 0;
        int i = 0;
        int j = 0;
        int k = 0;
        int s = 0;
        Point[] p = new Point[13];
        Button[] b = new Button[13];
        Point p1, p2;
        Graphics g;
        Boolean ok;
        String[] c = new String[14];
        public static Boolean update = false;
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\rad\Desktop\Rad Rares\2015 j 1\2015 j 1\Turism.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string[] v = new string[100];
        public Admin()
        {
            InitializeComponent();
            string cale = Application.StartupPath;
            cale = cale.Substring(0, cale.Length - 10);
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + cale + @"\Turism.mdf;Integrated Security=True;User Instance=True");
            cmd.Connection = cn;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turismDataSet3.Distante' table. You can move, or remove it, as needed.
            this.distanteTableAdapter1.Fill(this.turismDataSet3.Distante);
           
            g = pictureBox1.CreateGraphics();
            b = new Button[] { Constata, Varna, Burgas, Instambul, Kozlu, Samsun, Batumi, Sokhumi, Soci, Anapa, Yalta, Sevastopol, Odessa };
            for (int i = 0; i < 13; i++)
            {
                b[i].BackColor = Color.Blue;
                b[i].FlatStyle = FlatStyle.Flat;
                b[i].Text = i.ToString();
                b[i].Click += new EventHandler(ButtonClick);
                k++;
                b[i].Tag = k.ToString();
            }
            /*
            cn.Open();
            cmd.CommandText = "delete from Lista";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from Distante";
            cmd.ExecuteNonQuery();
            cn.Close();*/
             
             
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (ok == true)
            {
                if (i < 13)
                {
                    but.Tag = b[i].Tag;
                    cn.Open();
                    cmd.CommandText = "insert into Porturi(Nume_port,X,Y) values('" + but.Name + "','" + but.Location.X + "','" + but.Location.Y + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Portul a fost adaugat");
                    Pen q = new Pen(Color.FromArgb(255, 0, 0, 255), 4);
                    p1 = but.Location;
                    if (j > 0 && p1 != p2)
                    {
                        g.DrawLine(q, p1, p2);
                    }
                    if (p1 == p2)
                        MessageBox.Show("Nu puteti alege acelasi port!");
                    p2 = p1;
                    j++;
                    cn.Close();
                }
                else
                    MessageBox.Show("Poti alege doar 13 porturi");
                i++;
            }
            else
                MessageBox.Show("Initializati coordonatele");
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            label1.Text = "X: " + Cursor.Position.X.ToString();
            label2.Text = "Y: " + Cursor.Position.Y.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lista l = new Lista();
            l.Show();
        }

       /* private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ok == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    //  Pen q = new Pen(new SolidBrush(Color.Blue));
                    Pen q = new Pen(Color.FromArgb(255, 0, 0, 255), 4);
                    if (i < 13)
                    {
                        p[i] = new Point();
                        p[i] = b[i].Location;
                        p1 = p[i];

                        i++;
                        if (i > 1)
                        {
                            g.DrawLine(q, p2, p1);
                        }
                        p2 = p1;
                       
                    }
                        
                    else
                    {
                        MessageBox.Show("Doar 13 porturi sunt valabile!");
                    }
                }
            }
            else
                MessageBox.Show("Initializati introducerea de rute noi!");

        }
        /*/

        private void button1_Click(object sender, EventArgs e)
        {
            ok = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            ok = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            update = true;
            teapa t = new teapa();
            t.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

           // dataGridView1.DataSource = null;
           // dataGridView1.Rows.Clear();
            int g = 0;
            int z = 0;
            int d = 12;
            Button but = (Button)sender;
            string c = Application.StartupPath;
            c = c.Substring(0, c.Length - 10);
            c += @"\Resurse_C#\Harta_Distantelor.txt";
            StreamReader sr = new StreamReader(c);
            while (sr.EndOfStream == false )
            {
                string l = sr.ReadLine();
                if (l != "")
                {

                    for (int i = 0; i <=12; i++)
                    {

                        but.Tag = b[g].Tag;
                        v = l.Split(' ');
                        
                        for (int j = 0; j <= 12; j++)
                        {
                            int x = i + 1, y = j + 1;
                            dataGridView1.Rows[0].Cells[0].Value = x;
                            dataGridView1.Rows[0].Cells[1].Value = y;
                            dataGridView1.Rows[0].Cells[2].Value = but.Name;
                            dataGridView1.Rows[0].Cells[3].Value = v[j];
                           /* cn.Open();
                            cmd.CommandText = "insert into Distante(ID_Port,ID_Port_Dist,Nume_Port_Dest,Distanta) values('" + x + "','" + y + "','" + but.Name + "','" + v[j] + "')";
                            cmd.ExecuteNonQuery();
                            cn.Close();*/

                        }
                    }
                    //d += 12;
                }
            if (g < 13)
                g++;
            }
        }
        
    }
}
