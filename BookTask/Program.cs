using BookTask.Sql;
using System;

namespace BookTask
{
    class Program
    {
        static void Main(string[] args)
        {

            //CRUD emelyatlari ishleyir ancaq ki bundan sonra ne edim bilmedim :(
             //SqlBook.Insert("book1",40,40,10);
            //SqlBook.Delete(1);
            //SqlBook.GetAllData();
            //SqlAuthor.Insert("Tosu Zengilan");
             //SqlBook.GetAllData();
            SqlAuthor.GetAllData();
        }
    }
}
