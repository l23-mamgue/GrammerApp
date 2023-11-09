using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrammerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Startbutton.BackColor = Color.FromArgb(1, 80, 147);
            stopbutton.BackColor = Color.FromArgb(1, 80, 147);
         


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Copiez les valeurs RGB de Just Color Picker
            panel1.BackColor = Color.FromArgb(1, 80, 147); // code couleur RGB

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
           
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
