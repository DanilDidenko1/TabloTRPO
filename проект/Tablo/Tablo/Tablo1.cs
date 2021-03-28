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
    public partial class Tablo1 : Form
    {
        public Tablo1()
        {
            InitializeComponent();
        }
        private void Reistimerarrived()
        {

            if (DateTime.Now >= Reis.date)
            {
                if (label3.Text == Reis.nametrain)
                {
                    if (Reis.intervalsec > 0)
                    {
                        Reis.intervalsec--;
                        time.Text = Reis.intervalmin + ":" + Reis.intervalsec.ToString();
                        
                    }
                    else if (Reis.intervalmin > 0)
                    {
                        Reis.intervalmin--;
                        Reis.intervalsec = 60;
                    }
                    if (Reis.intervalmin == 0 && Reis.intervalsec == 0)
                    {
                        time.Text = "Поезд прибыл";
                    }
                }
                else
                {
                   
                    if (Reis.intervalsec > 0)
                    {
                        Reis.intervalsec--;
                        time1.Text = Reis.intervalmin + ":" + Reis.intervalsec.ToString();
                    }

                    else if (Reis.intervalmin > 0)
                    {
                        Reis.intervalmin--;
                        Reis.intervalsec = 60;
                    }

                }
            }
        }

        private void Reis1timerarrived()
        {
           
            if (DateTime.Now >= Reis1.date1)
            {
                if (label3.Text == Reis1.nametrain1)
                {
                    
                    if (Reis1.intervalsec1 > 0)
                    {
                        Reis1.intervalsec1--;
                        time.Text = Reis1.intervalmin1 + ":" + Reis1.intervalsec1.ToString();
                    }

                    else if (Reis1.intervalmin1 > 0)
                    {
                        Reis1.intervalmin1--;
                        Reis1.intervalsec1 = 60;
                    }

                    if (Reis1.intervalmin1 == 0 && Reis1.intervalsec1 == 0)
                    {
                        time.Text = "Поезд прибыл";
                    }

                }
                else
                {
                   
                    if (Reis1.intervalsec1 > 0)
                    {
                        Reis1.intervalsec1--;
                        time1.Text = Reis1.intervalmin1 + ":" + Reis1.intervalsec1.ToString();
                       
                    }

                    else if (Reis1.intervalmin1 > 0)
                    {
                        Reis1.intervalmin1--;
                        Reis1.intervalsec1 = 60;
                    }
                }
            }
        }

        private void Reistimerwait()
        {
            if (label3.Text == Reis.nametrain)
            {
                if (Reis.intervalmin == 0 && Reis.intervalsec == 0)
                {
                    if (Reis.waitsec > 0)
                    {
                        Reis.waitsec--;
                        label9.Text = Reis.waitminute + ":" + Reis.waitsec.ToString();
                    }

                    else if (Reis.waitminute > 0)
                    {
                        Reis.waitminute--;
                        Reis.waitsec = 60;
                    }

                    if(Reis.waitminute==0 && Reis.waitsec==0)
                    {
                        label9.Text = "";
                    }
                }
            }
            else
            {
            }
        }

        private void Reis1timerwait()
        {
            if(label3.Text==Reis1.nametrain1)
            {
                if (Reis1.intervalmin1 == 0 && Reis1.intervalsec1 == 0)
                {
                    if (Reis1.waitsec1 > 0)
                    {
                        Reis1.waitsec1--;
                        label9.Text = Reis1.waitminute1 + ":" + Reis1.waitsec1.ToString();
                    }

                    else if (Reis1.waitminute1 > 0)
                    {
                        Reis1.waitminute1--;
                        Reis1.waitsec1 = 60;
                    }

                    if (Reis1.waitminute1 == 0 && Reis1.waitsec1 == 0)
                    {
                        label9.Text = "";
                    }
                }
            }
        }

        private void Obmen()
        {
            string tk;
            string ob;
            ob = label3.Text;
            label3.Text = label10.Text;
            label10.Text = ob;
            tk = time.Text;
            time.Text = time1.Text;
            time1.Text = tk;
            label9.Text = "Поезд еще не прибыл";
        }

        private void Tablo1_Load(object sender, EventArgs e)
        {
            showTimeNow.Start();
            arivetimer.Start();
            label9.Text = "Поезд еще не прибыл";
            if (Reis.starttrain < Reis1.starttrain1)
            {
                label3.Text = Reis.nametrain;
                label10.Text = Reis1.nametrain1;

            }
            else
            {
                label3.Text = Reis1.nametrain1;
                label10.Text = Reis.nametrain;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timetablo.Text = DateTime.Now.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Reis.starttrain < Reis1.starttrain1)
            {
                Reistimerarrived();
                Reistimerwait();
                Reis1timerarrived();
                Reis1timerwait();
                if (label9.Text == "")
                {
                    Obmen();
                    
                        if (Reis.intervalmin == 0 && Reis.intervalsec == 0)
                        {
                            Reis.intervalmin = Reis.cst;
                        }
                        if (Reis1.intervalmin1 == 0 && Reis1.intervalsec1 == 0)
                        {
                            Reis1.intervalmin1 = Reis1.cst1;
                        }
                    
                    
                }
            }
            else
            {
                Reis1timerarrived();
                time.Text = Reis1.timer1;
                Reis1timerwait();
            }

             
        }

 
    }
}
               
          
      
