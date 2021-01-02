using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubg_App.Model.Silahlar
{
    public class M51 : AtesliSilah, IYakinlastirabilir
    {
        public void Yakinlastir()
        {
            System.Windows.Forms.MessageBox.Show("Silah 4x ile yakınlaştırıldı");
        }
    }
}
