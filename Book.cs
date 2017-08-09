using System;

namespace csharpdemo
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public static Book[] GetBooks()
        {
            return new Book[] {
                 new Book { Title="C# 5.0", Author ="Anders", Price = 550},
                 new Book { Title="Oracle Database 12c", Author ="Jason Price", Price = 650},
                 new Book { Title="Asp.net 4.5 Unleahsed", Author ="Walther", Price = 799},
                 new Book { Title="ASP.NET MVC Unleashed", Author ="Stephen Walther", Price = 500},
                 new Book { Title="Angular 2", Author ="Miller", Price = 350}
            };
        }
    } 
}
