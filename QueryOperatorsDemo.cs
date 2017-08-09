using System;
using System.Linq;

namespace csharpdemo
{
    class QueryOperatorsDemo
    {
        static void Main()
        {

            Book[] books = Book.GetBooks();

            var top3books = books.Take(3);  // take first 3 books 
            
            var sb = books.Where(b => b.Title.StartsWith("A"))
                          .OrderByDescending(b => b.Price);

            foreach (var b in sb)
                Console.WriteLine("{0},{1}", b.Title, b.Price);
            
            
            var max = books.Max(b => b.Price);

            var hpb = books.Where(b => b.Price == max).First();
           

            //foreach (var b in sb)
            //    Console.WriteLine("{0},{1}", b.Title, b.Price );



            //var minprice = books.Min(b => b.Price);
            //var books2 = books.Where(b => b.Price == minprice);
            //var sbooks2 = books2.OrderBy(b => b.Title);


            //var books3 = from b in books
            //             where b.Price > 500
            //             select new { b.Title, b.Author };



            // query methods
            //var selectedbooks = books.Where(b => b.Title.Length > 20 && b.Price > 500).Take(5);
           

            //foreach (var book in selectedbooks)
            //    Console.WriteLine(" Tile : {0}  Price : {1}", book.Title, book.Price);

            //var selectedbooks2 = books.Skip(2).Take(2); // only 2 books from 3rd book
            //var totalprice = books.Sum(b => b.Price); 

            //// query methods - sort books on descending order of price then by ascending order of title
            //var sortedbooks = books.OrderByDescending(b => b.Price)
            //                                .OrderBy(b => b.Title);

            //foreach (var book in sortedbooks)
            //    Console.WriteLine(" Tile : {0}  Price : {1}", book.Title, book.Price);

            //var maxprice = books.Max(b => b.Price);
            //var mp_book = books.Where(b => b.Price == maxprice).First().Title;
            //Console.WriteLine(mp_book);

            //Console.WriteLine("{0} book with price {1} is the highest priced book", mp_book.Title, mp_book.Price);

            //var sb = books
            //                   .Where(b => b.Author.Length > 5 && b.Price < 600)
            //                   .OrderBy(b => b.Title)
            //                   .Select(b => new { b.Title, NetPrice = b.Price * 0.80 });

            //foreach (var b in sb)
            //    Console.WriteLine(" {0} {1}", b.Title, b.NetPrice);

            //var sb2 = from b in books
            //          where b.Author.StartsWith("A") && b.Price < 600
            //          orderby b.Title
            //          select new { b.Title, NetPrice = b.Price * 0.80 };

            //foreach (var b in sb2)
            //    Console.WriteLine(" {0} {1}", b.Title, b.NetPrice);

        }

    }
}
