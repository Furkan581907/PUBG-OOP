using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubg_App.Model
{
    public abstract class Silah
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public float Agirlik { get; set; }
    }
}
