using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace fxp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            for (int i = 0; i < 9999; i++)
            {
                Random rnd1 = new Random();
                string dice1 = rnd1.Next(0, 9999).ToString();   // creates a number between 1 and 9
                Random rnd2 = new Random();
                string dice2 = rnd1.Next(0, 9999).ToString();   // creates a number between 1 and 9
                Random rnd3 = new Random();
                string dice3 = rnd1.Next(0, 9999).ToString();   // creates a number between 1 and 9
                Random rnd4 = new Random();
                string dice4 = rnd1.Next(0, 9999).ToString();   // creates a number between 1 and 9
                textBox1.Text = dice1;
                textBox2.Text = dice2;
                textBox3.Text = dice3;
                textBox4.Text = dice4;
                //let's go dance!
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Select a empty text file!"
                
            };

            
            
            
            

        }
    }
    
}
