using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public class StoredItems
    {
        private Item[] _items;
        private int _count;

        public StoredItems(int size)
        {
            _items = new Item[size];
            _count = 0;
            
        }

        public int Count
        {
            get { return _count; }
        }
        public int Capacity
        {
            get { return 20; } // FIXME: return _items.Length;
        }
        public Item GetItem(int index)
        {
            return _items[index];

        }
        public Item SetItem(int index, Item item)
        {
            // FIXME: See below
            //Item oldItem = _items[index];
            //_items[index] = item;
            //return oldItem;

            Item oldItem = _items[index];
            _items[index] = item;
            ++_count;
            return null;
        }
        public void AddItem(Item item)
        {
            if(_count < Capacity)
            {
                _items[_count] = item;
                ++_count;
            }
            else
            {
                throw new BagFullException();
            }
            
        }
        public void RemoveItem(Item item)
        {
            int foundIndex = -1;
            
            for (int i = 0; i < _count; i++)
            {
                if(_items[i] == item)
                {
                    foundIndex = i;
                    _items[i] = null;
                    --_count;
                    break;
                }
                
            }
            if(foundIndex >= 0)
            {
                for (int i = foundIndex; i < _count; i++)
                {
                    _items[i] = _items[i + 1];
                }
            }
            

        }

        public double CalcTotalWeight()
        {
            double sum = 0;
            for (int i = 0; i < _count; i++)
            {
                if (_items[i] != null)
                {
                    sum += _items[i].Weight;
                }
            }
            return sum;
        }


    }
}
