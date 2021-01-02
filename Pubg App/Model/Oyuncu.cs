using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubg_App.Model
{
    public class Oyuncu
    {
        public string Adi { get; set; }
        public string Yas { get; set; }
        public Silah Silah { get; set; }
        public void NisanAl()
        {
            System.Windows.Forms.MessageBox.Show("Nişan Alındı");
        }
        public void Saldir()
        {
            System.Windows.Forms.MessageBox.Show("Hedef Vuruldu");
        }
    }
}
