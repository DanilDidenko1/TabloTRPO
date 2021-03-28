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
    public partial class changeraspis : Form
    {
        public changeraspis()
        {
            InitializeComponent();
          
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Рейс 1")
            {
                if (Reis.intervalmin==0 && Reis.intervalsec==0)
                {
                    int pp = Convert.ToInt32(textBox1.Text);
                    if (pp<60) 
                    {
                        Reis.intervalmin = Convert.ToInt32(textBox1.Text);
                    }
                   else MessageBox.Show("введите интервал меньше 60 минут");
                }
                    
            }
            if (comboBox1.Text == "Рейс 2")
            {
                if (Reis1.intervalmin1 == 0 && Reis1.intervalsec1 == 0)
                {
                    int po = Convert.ToInt32(textBox1.Text);
                    if (po < 60)
                    {
                        Reis1.intervalmin1 = Convert.ToInt32(textBox1.Text);
                    }
                   else MessageBox.Show("введите интервал меньше 60 минут");
                }

            }
        }
    }
}
