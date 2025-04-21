using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabirimler
{
    internal interface IKisi
    {
        string Adi { get; set; }
        string Soyadi { get; set; }
        string bilgi();
    }
}
