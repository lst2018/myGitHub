using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readTextFileAndDatabase
{
    public partial class Form1 : Form
    {
        /*
         Title: Demonstrating coding program using c#; 
         Purposed: oop database connection
         Created by: Liston Sitorus
         Created Date: 01 October 2018
        */
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadTextFile actForm = new ReadTextFile();
                actForm.Show();
        }

        

        private void pb1_MouseLeave(object sender, EventArgs e)
        {
            pb1.Image = Properties.Resources._8_2;
        }

        private void pb1_MouseHover(object sender, EventArgs e)
        {
            pb1.Image = Properties.Resources._8;
            
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             ReadDb actForm = new ReadDb();
            actForm.Show();
        }
    }
}
