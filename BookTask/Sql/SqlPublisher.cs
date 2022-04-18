using BookTask.DAL;
using BookTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTask.Sql
{
    class SqlPublisher
    {

        public static void Insert(string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Publisher publisher = new Publisher() { Name = name };
                sql.Publishers.Add(publisher);
                sql.SaveChanges();
            }
        }
        public static void Update(int id,string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Publisher publisher = sql.Publishers.SingleOrDefault(x => x.Id == id);
                publisher.Name = name;
                sql.Update(publisher);
                sql.SaveChanges();
            }
        }
        public static void Delete(int id)
        {
            using (AppDbContext sql =new AppDbContext())
            {
                Publisher publisher = sql.Publishers.SingleOrDefault(x => x.Id == id);
                sql.Publishers.Remove(publisher);
                sql.SaveChanges();
            }
        }
        public static void GetAllData()
        {
            using (AppDbContext sql = new AppDbContext())
            {
                List<Publisher> publishers = sql.Publishers.ToList(); ;
                foreach (Publisher item in publishers)
                {
                    Console.WriteLine($"Id {item.Id},Name {item.Name}");
                }

            }
        }
    }
}
