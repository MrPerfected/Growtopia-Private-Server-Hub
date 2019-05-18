using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Private_Server_Hub
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string text = File.ReadAllText(@"c:\windows\system32\drivers\etc\hosts");
            richTextBox1.Text = text;
        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string txt = richTextBox1.Text;
            File.WriteAllLines(@"c:\windows\system32\drivers\etc\hosts", new[] { txt });
            MessageBox.Show("Hosts Saved!");
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
