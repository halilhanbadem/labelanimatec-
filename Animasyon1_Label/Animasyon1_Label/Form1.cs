using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animasyon1_Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string icerik = "ÖMER FARUK";
        string temp_icerik = "";
        char[] alfabe = {'A','B','C','Ç','D','E','F','G','Ğ','H','I','İ','J','K','L','M','N','O','Ö','P','R','S','Ş','T','U','Ü','Y','Z', ' '};
        int X = 0;
        int Y = 0;


        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
    

            for (int i = 0; i < icerik.Length; i++)
            {
                label1.Text += "X";
            }

            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                label1.Text = temp_icerik + alfabe[X].ToString() + label1.Text.Substring(Y + 1);

                if (icerik[Y] == alfabe[X])
            {
                temp_icerik += alfabe[X].ToString();
                Y++;
                X = 0;
                return;
            }

                    X++;

            }
            catch (Exception)
            {
                timer1.Enabled = false;
            }
        }
    }
}
