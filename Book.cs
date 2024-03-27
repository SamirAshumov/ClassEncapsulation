using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    internal class Book : Product
    {
        public string Genre;

        public Book() { }

        public Book(int no, double price, string name, string genre) 
        {
            this.No = no;
            this.getPrice = price;
            this.Name = name;
            this.Genre = genre;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{this.No} - {this.Name} [Genre] : {this.Genre}  [Price] : {this.getPrice} [Count] : {this.getCount}");
        }                            

    }
}
