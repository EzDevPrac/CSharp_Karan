using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShopItteratorPattern
{
    /// Our collection item.
    public class IceCream
    {
        private string _flavor;

        // Constructor
        public IceCream(string flavor)
        {
            this._flavor = flavor;
        }

        
        public string Flavor
        {
            get { return _flavor; }
        }
    }}
