using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEncapsulation
{
    internal class Library 
    {
        public Book[] books = new Book[] { };


        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] BooksByGenre = new Book[] { };

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Genre == genre)
                {
                    Array.Resize(ref BooksByGenre, BooksByGenre.Length + 1);
                    BooksByGenre[BooksByGenre.Length - 1] = books[i];
                }
            }

            return BooksByGenre;
        }

        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] BooksByPrice = new Book[] { };
            for (int i = 0; i < books.Length; i++)
            {
                if (minPrice <= books[i].getPrice && books[i].getPrice <= maxPrice)
                {
                    Array.Resize(ref BooksByPrice, BooksByPrice.Length + 1);
                    BooksByPrice[BooksByPrice.Length - 1] = books[i];
                }
            }
            return BooksByPrice;
        }
               
        public void ShowAllBooks()
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i].ShowInfo();
            }
        }

        public void ShowAllBooks(Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i].ShowInfo();
            }
        }
    }
}
