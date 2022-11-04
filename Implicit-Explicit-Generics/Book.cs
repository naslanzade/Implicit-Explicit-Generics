using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_Explicit_Generics
{
    public class Book
    {
        public string Name { get; set; }

        public class BookList
        {
            private Book[] _arr;

            public BookList()
            {
                _arr = new Book[0];
            }


            public void Add(Book book)
            {
                Array.Resize(ref _arr, _arr.Length + 1);

                _arr[_arr.Length - 1] = book;
            }


            public void GetAll()
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    Console.WriteLine(_arr[i].Name);
                }
            }
        }




    }
}
