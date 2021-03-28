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

    public partial class Getraspisane : Form
    {
        public Getraspisane()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Рейс 1")
            {
                Reis.intervalmin = 0;
                Reis.date = DateTime.MinValue;
                int pt = Convert.ToInt32(textBox1.Text);
                if (pt < 59)
                {
                    Reis.intervalmin = Convert.ToInt32(textBox1.Text);
                    Reis.cst = Convert.ToInt32(textBox1.Text);
                }
                else MessageBox.Show("введите интервал меньше 60 минут");
               
            }
            else if (comboBox1.Text == "Рейс 2")
            {
                Reis1.intervalmin1 = 0;
                Reis1.date1 = DateTime.MinValue;
                int ps = Convert.ToInt32(textBox1.Text);
                if (ps < 59)
                {
                    Reis1.intervalmin1 = Convert.ToInt32(textBox1.Text);
                    Reis1.cst1 = Convert.ToInt32(textBox1.Text);
                }
                else MessageBox.Show("введите интервал меньше 60 минут");
            }
            try
            {
                if (comboBox1.Text == "Рейс 1")
                {
                    textBox2.Text += "50";
                    Reis.date = DateTime.Parse(textBox2.Text);    
                    Reis.starttrain = DateTime.Parse(textBox2.Text);
                }
                else if (comboBox1.Text == "Рейс 2")
                {
                    Reis1.date1 = DateTime.Parse(textBox2.Text);
                    Reis1.starttrain1 = DateTime.Parse(textBox2.Text);
                }
            }
            catch
            {
                MessageBox.Show("Неверно введено время");
            }
        }
    }
}
       