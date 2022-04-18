using BookTask.DAL;
using BookTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTask.Sql
{
    class SqlGenre
    {
        public static void GetAllData()
        {
            using (AppDbContext sql = new AppDbContext())
            {                
                List<Genre> genres = new List<Genre>();

                foreach (Genre item in genres)
                {
                    Console.WriteLine($"Id {item.Id},Name {item.Name}");
                }

            }
        }
        public static void Delete(int id)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Genre genre = sql.Genres.SingleOrDefault(x => x.Id == id);

                sql.Genres.Remove(genre);
                sql.SaveChanges();
            }
        }
        public static void Update(int id, string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {

                Genre  genre= sql.Genres.SingleOrDefault(x => x.Id == id);

                genre.Name = name;
               
                sql.Update(genre);
                sql.SaveChanges();

            }
        }
        public static void Insert(string name)
        {
            using (AppDbContext sql = new AppDbContext())
            {
                Genre genre = new Genre() { Name = name };
                sql.Genres.Add(genre);
                sql.SaveChanges();
            }
        }

    }
}
