using BookTask.DAL;
using BookTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTask.Sql
{
    class SqlAuthor
    {
        public static void GetAllData()
        {
            using (AppDbContext sql =new AppDbContext())
            {
                List<Author> authors = sql.Authors.ToList();
                foreach (var item in authors)
                {
                    Console.WriteLine($"Id {item.Id},Full name {item.SurnameName}");
                }
            }
        }
        public static void Update(int id,string fullName)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Author author = sql.Authors.SingleOrDefault(x=>x.Id==id);
                author.SurnameName = fullName;
                sql.Update(author);
                sql.SaveChanges();
            }
        }
        public static void Delete(int id)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Author author = sql.Authors.SingleOrDefault(x=>x.Id==id);
                sql.Authors.Remove(author);
                sql.SaveChanges();
            }
        }
        public static void Insert(string fullName)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Author author = new Author() { SurnameName = fullName };
                sql.Authors.Add(author);
                sql.SaveChanges();
                
                
            }
        }
    }
}
