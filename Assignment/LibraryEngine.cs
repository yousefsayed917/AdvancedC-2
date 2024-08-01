using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //public delegate string BookFuncDelegate(Book book);
    internal class LibraryEngine
    {
        //public static void ProcessBooks(List<Book> blist, BookFuncDelegate bookFuncDelegate)
        //{
        //    if (blist != null && bookFuncDelegate != null)
        //    {
        //        foreach (Book B in blist)
        //            Console.WriteLine(bookFuncDelegate(B));
        //    }
        //}
        public static void ProcessBooks(List<Book> blist, Func<Book,string> bookFuncDelegate)
        {
            if (blist != null && bookFuncDelegate != null)
            {
                foreach (Book B in blist)
                    Console.WriteLine(bookFuncDelegate(B));
            }
        }
    }
}
