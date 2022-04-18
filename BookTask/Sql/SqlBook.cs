using BookTask.DAL;
using BookTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTask.Sql
{
    public class SqlBook
    {
        public static void Insert(string name,int pagecount,int stockcount,double price)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Book book = new Book() { Name = name, StockCount= pagecount, PageCount= stockcount, Price= price };
                sql.Books.Add(book);
                sql.SaveChanges();
            }
        }
        public static void Update(int id, string name, int pagecount, int stockcount, double price)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                
                Book book = sql.Books.SingleOrDefault(x=>x.Id==id);
                           
                book.Name = name;
                book.PageCount = pagecount;
                book.StockCount =stockcount;
                book.Price = price;

                sql.Update(book);
                sql.SaveChanges();
                
            }
        }
        public static void GetAllData()
        {
            using (AppDbContext sql = new AppDbContext())
            {
                List<Book> books = sql.Books.ToList();
                foreach (Book item in books)
                {
                    Console.WriteLine($"Id {item.Id},Name {item.Name},Price {item.Price},StockCount {item.StockCount},PageCount {item.PageCount}");
                }


            }
        }
        public static void Delete(int id)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Book book = sql.Books.SingleOrDefault(x => x.Id == id);

                sql.Books.Remove(book);
                sql.SaveChanges();               
            }
        }

    }
}
