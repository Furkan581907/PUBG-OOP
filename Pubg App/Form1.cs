using Pubg_App.Model;
using Pubg_App.Model.Silahlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pubg_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Oyuncu p1 = new Oyuncu();
            M51 m51 = new M51();
            p1.Adi = "Furkan";
            p1.Yas = "25";
            p1.Silah = m51;
            p1.NisanAl();
            p1.Saldir();
        }
    }
}
