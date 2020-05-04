using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamShopItteratorPattern
{
    /// The concrete aggregate class
    class IceCreamCollection : IIceCreamCollection
    {
        private ArrayList _items = new ArrayList();

        public IceCreams CreateIterator()
        {
            return new IceCreams(this);
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

}
