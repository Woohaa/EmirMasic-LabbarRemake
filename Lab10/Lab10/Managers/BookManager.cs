using Lab10.Filters;
using Lab10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Managers
{
    class BookManager
    {
        List<Book> bookList = new List<Book>()
        {
            new Book {Title = "Me and my tiny box of...", BookGenre = Genre.Romance, Pages = 679, Price = 435.99 },
            new Book {Title = "Plastic spaceships, next generation", BookGenre = Genre.Scifi, Pages = 234, Price = 31.99 },
            new Book {Title = "How I became my own cat", BookGenre = Genre.Biography, Pages = 123, Price = 230.99 },
            new Book {Title = "Farming gold fast", BookGenre = Genre.Fantasy, Pages = 5524, Price = 4439.99 },
            new Book {Title = "Living with a big D", BookGenre = Genre.Biography, Pages = 63, Price = 1.99 },
            new Book {Title = "How to be rude", BookGenre = Genre.Thriller, Pages = 345, Price = 199.99 },
            new Book {Title = "The JELLY", BookGenre = Genre.Mystery, Pages = 878, Price = 1099.99 },
            new Book {Title = "Excuse me may I take this?", BookGenre = Genre.Romance, Pages = 764, Price = 899.99 },
            new Book {Title = "Avaria", BookGenre = Genre.Fantasy, Pages = 234, Price = 419.99 },
            new Book {Title = "I dropped my butter, but also the money", BookGenre = Genre.Thriller, Pages = 392, Price = 349.99 },
            new Book {Title = "My life as Olf Dolf", BookGenre = Genre.Biography, Pages = 435, Price = 89.99 },
        };

        public void PrintWhere(BookFilter bookFilter)
        {
            foreach (var book in bookList)
            {
                if (bookFilter(book))
                    Console.WriteLine(book);

            }
        }
    }
}
