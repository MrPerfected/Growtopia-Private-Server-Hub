using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.Diagnostics;
using System.IO;

namespace Private_Server_Hub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string extension = ".ini";
            filePath += @"\config" + extension;

            //   string config = File.ReadAllText(filePath);
            if (!File.Exists(filePath))
            {
                using (StreamWriter w = new StreamWriter(filePath))
                {

                    w.WriteLine("Vyte:145.239.149.135");
                    w.WriteLine("MNT:35.228.28.75");
                    w.WriteLine("Custom:127.0.0.1");

                }
            }


           
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            string text = string.Empty;
            File.WriteAllLines(@"c:\windows\system32\drivers\etc\hosts", new[] { text });
            MessageBox.Show("Connected to Regular GT");
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                w.WriteLine("#Perfected's GTPS hub");
                w.WriteLine("#GROWTOPIA MAIN SERVERS");
      
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string extension = ".ini";
            filePath += @"\config" + extension;
            string line = File.ReadLines(filePath).ElementAt(1 - 1); //string line = File.ReadLines(filePath).ElementAt(actualLine - 1);
            string[] serverAddress = line.Split(':');

            string text = string.Empty;
            File.WriteAllLines(@"c:\windows\system32\drivers\etc\hosts", new[] { text });
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                w.WriteLine("#Perfected's GTPS hub");
                w.WriteLine("#Vyte");
                w.WriteLine(serverAddress[1] + " growtopia1.com");
                w.WriteLine(serverAddress[1] + " growtopia2.com");
                w.WriteLine("");
          
            }
            MessageBox.Show("Connected to Vytes GTPS3");
        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string extension = ".ini";
            filePath += @"\config" + extension;
            string line = File.ReadLines(filePath).ElementAt(2 - 1); //string line = File.ReadLines(filePath).ElementAt(actualLine - 1);
            string[] serverAddress = line.Split(':');

            string text = string.Empty;
            File.WriteAllLines(@"c:\windows\system32\drivers\etc\hosts", new[] { text });
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                w.WriteLine("#Perfected's GTPS hub");
                w.WriteLine("#MNT");
                w.WriteLine(serverAddress[1] + " growtopia1.com");
                w.WriteLine(serverAddress[1] + " growtopia2.com");
        
            }
            MessageBox.Show("Connected to Project MNT");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string extension = ".ini";
            filePath += @"\config" + extension;
            string line = File.ReadLines(filePath).ElementAt(3 - 1); //string line = File.ReadLines(filePath).ElementAt(actualLine - 1);
            string[] serverAddress = line.Split(':');

            string text = string.Empty;
            File.WriteAllLines(@"c:\windows\system32\drivers\etc\hosts", new[] { text });
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                w.WriteLine("#Cryotes GTPS hub");
                w.WriteLine(serverAddress[1] + " growtopia1.com");
                w.WriteLine(serverAddress[1] + " growtopia2.com");

            }
            MessageBox.Show("Connected to Custom Server");
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
