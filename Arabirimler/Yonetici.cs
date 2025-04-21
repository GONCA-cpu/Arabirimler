using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabirimler
{
   public class Yonetici:IKisi
    {
       
        public string Adi {
            get => Convert.ToString("******") ; 
            set => Convert.ToString("******") ; 
        }
        public string Soyadi { get => "------"; set => Convert.ToString(Soyadi); }

        public string bilgi()
        {
           return Adi + " " + Soyadi;
        }
    }
}
