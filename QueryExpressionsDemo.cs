using System;
using System.Linq;

namespace csharpdemo
{
    class QueryExpressionsDemo
    {
        static void Main()
        {
            Book[] books = Book.GetBooks();

            var books1 = from b in books
                         where b.Price > 500
                         select b;

            var sbooks =  from b in books
                          // where b.Price > 500
                          orderby b.Title 
                          select new { Title = b.Title, 
                                       Price = b.Price,
                                       SellingPrice = b.Price > 500 ? b.Price * 0.8 : b.Price *  0.9};

            foreach (var b in sbooks)
                Console.WriteLine("{0} - {1}  - {2}", b.Title, b.Price, b.SellingPrice);
            
            // get books with max price 
            var maxprice = books.Max( b => b.Price );
            var maxbook = (from b in books
                           where b.Price == maxprice
                           select b).Single();



            // var c1 = from b in books
            //          where b.Price > 200 
            //          orderby  b.Title 
            //          select b;

            // foreach (var book in c1)
            //     Console.WriteLine(" Tile : {0}  Price : {1}  Author : {2}",
            //             book.Title, book.Price, book.Author );


            //var selectedbooks = from book in books
            //                     where book.Price > 500
            //                     orderby book.Title
            //                     select new { book.Title,
            //                                  book.Price,
            //                                  Discount = book.Price * 0.10} ;

            // foreach (var book in selectedbooks)
            //     Console.WriteLine(" Tile : {0}  Price : {1} Discount : {2}", 
            //             book.Title, book.Price, book.Discount );

            // // query expression
            // var sortedbooks = from b in books
            //                    orderby b.Price descending
            //                    orderby b.Title
            //                    select b;

            // foreach (var book in sortedbooks)
            //     Console.WriteLine(" Tile : {0}  Price : {1}", book.Title, book.Price);

            //var maxprice = books.Max(b => b.Price);

            //var mp_book = (from book in books
            //               where book.Price > 500
            //               select new { BookTitle = book.Title, SellingPrice = book.Price }
            //               ).SingleOrDefault();

            // Console.WriteLine("{0} book with price {1} is the highest priced book", mp_book.BookTitle, mp_book.SellingPrice);

            //var b = (from b in books
            //         where b.Price > 300 && b.Title.Length > 10
            //         select new { Title = b.Title, DiscountedPrice = b.Price * 0.85 })
            //        .Take(4);



        }
    }
}
