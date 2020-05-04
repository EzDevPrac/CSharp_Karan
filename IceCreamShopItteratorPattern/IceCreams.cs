using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShopItteratorPattern
{
    /// The 'ConcreteIterator' class
    class IceCreams : IIceCreams
    {
        private IceCreamCollection _IceCreams;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public IceCreams(IceCreamCollection cream)
        {
            this._IceCreams = cream;
        }

        // Gets first jelly bean
        public IceCream First()
        {
            _current = 0;
            return _IceCreams[_current] as IceCream;
        }

        // Gets next jelly bean
        public IceCream Next()
        {
            _current += _step;
            if (!IsDone)
                return _IceCreams[_current] as IceCream;
            else
                return null;
        }

        // Gets current iterator candy
        public IceCream CurrentCream
        {
            get { return _IceCreams[_current] as IceCream; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _IceCreams.Count; }
        }
    }

}
