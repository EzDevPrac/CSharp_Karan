using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShopItteratorPattern
{   // The 'Iterator' interface
    
    interface IIceCreams
    {
        IceCream First();
        IceCream Next();
        bool IsDone { get; }
        IceCream CurrentCream { get; }
    }

    
}
