using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Cıkış_Saatleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            int indeks = comboBox1.SelectedIndex;
            

            if (indeks == 0 || indeks == 1 || indeks==2)
            {
                lblSonuc.Text = "Çıkış Saati 16.40'dır";
            }
            else if (indeks == 3||indeks==4)
            {
                lblSonuc.Text = "Çıkış Saati 15.50'dir";
            }
            else
            {
                lblSonuc.Text = "Tatil.";
            }

            


        }
    }
}
