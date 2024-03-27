namespace ClassEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            string check, genre;
            int min, max;

            Book book1 = new Book(1, 8.70, "Cinayet ve ceza", "Roman");
            library.AddBook(book1);
            Book book2 = new Book(2, 11.20, "Melek", "Fantastika");
            library.AddBook(book2);
            Book book3 = new Book(3, 9.50, "Gorunmez adam", "Fantastika");
            library.AddBook(book3);
            Book book4 = new Book(4, 10, "Reqemsal qala", "Detektiv");
            library.AddBook(book4);
            Book book5 = new Book(5, 7.20, "Cebheden cebheye", "Detektiv");
            library.AddBook(book5);
            Book book6 = new Book(6, 15.60, "The secret", "Psixoloji");
            library.AddBook(book6);
            Book book7 = new Book(7, 13, "Atomik verdisler", "Psixoloji");
            library.AddBook(book7);

            do
            {

                Console.WriteLine("\n1.Butun kitablarin siyahisini gor\n2.Janra gore filter et\n3.Qiymet araligina gore filter et\n");
                check = Console.ReadLine();

                if (check == "1")
                {
                    library.ShowAllBooks();
                }

                else if (check == "2")
                {
                    Console.WriteLine("\nJanri secin : \n1.Roman\n2.Fantastika\n3.Detektiv\n4.Psixoloji");
                    check = Console.ReadLine();

                    if (check == "1")

                        library.ShowAllBooks(library.GetFilteredBooks("Roman"));

                    else if (check == "2")

                        library.ShowAllBooks(library.GetFilteredBooks("Fantastika"));

                    else if (check == "3")

                        library.ShowAllBooks(library.GetFilteredBooks("Detektiv"));

                    else if (check == "4")

                        library.ShowAllBooks(library.GetFilteredBooks("Psixoloji"));

                    else
                        Console.WriteLine("Janr duzgun secilmeyib");

                }

                else if (check == "3")
                {
                    Console.WriteLine("Minumum qiymet araligini teyin edin : ");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Maximum qiymet araligini teyin edin : ");
                    max = Convert.ToInt32(Console.ReadLine());

                    library.ShowAllBooks(library.GetFilteredBooks(min, max));

                }

                else
                {
                    Console.WriteLine("\nSecim duzgun edilmeyib.Zehmet olmasa tekrar edin : \n");
                }
            }while(true);

        }
    }
}
