using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompleksVeriBaglama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVeriBagla_Click(object sender, EventArgs e)
        {
            string[] hicriAylar = { 
                    "Muharrem", "Safer", "Rebiulevvel", "Rebiulahir",
                    "Cemaziyelevvel","Cemaziyelahir","Receb","Şaban",
                    "Ramazan","Şevval","Zilkade","Zilhicce" };
            listBoxVeriler.DataSource = hicriAylar;
        }
    }
}

