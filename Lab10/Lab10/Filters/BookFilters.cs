using Lab10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Filters
{
    public delegate bool BookFilter(Book book);

    class BookFilters
    {
        public static bool IsNovel(Book book)
        {
            if (book.Pages >= 500)
                return true;
            else return false;
        }

        public static bool IsShortStory(Book book)
        {
            if (book.Pages <= 499)
                return true;
            else return false;
        }

        public static bool IsGenreMystery(Book book)
        {
            if (book.BookGenre == Genre.Mystery)
                return true;
            else return false;
        }

        public static bool IsGenreFantasy(Book book)
        {
            if (book.BookGenre == Genre.Fantasy)
                return true;
            else return false;
        }

        public static bool IsGenreRomance(Book book)
        {
            if (book.BookGenre == Genre.Romance)
                return true;
            else return false; 
        }

        public static bool IsCheap(Book book)
        {
            return book.Price < 300;
       
        }

        public static bool IsExpensive(Book book)
        {
            return book.Price > 300;
        }

    }
}
