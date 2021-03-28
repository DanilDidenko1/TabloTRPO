using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablo
{
    public partial class ПУ : Form
    {
        public ПУ()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label2.Text = DateTime.Now.ToString();
            
        }

        private void ПУ_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tablo1 tablo1 = new Tablo1();
            tablo1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Getraspisane getraspsa = new Getraspisane();
            getraspsa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeraspis changeraspis = new changeraspis();
            changeraspis.Show();
        }
    }
}
