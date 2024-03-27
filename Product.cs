using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    internal class Product : Library
    {
        private double _price;
        private int _count;
        public int No;
        public string Name;

        public double getPrice
        {
            set
            {
                _price = value;
            }   

            get 
            { 
                return _price;
            }
        }

        public int getCount
        {
            set
            {
                _count = value;
            }

            get
            {
                return _count;
            }
        }        
    }
}
