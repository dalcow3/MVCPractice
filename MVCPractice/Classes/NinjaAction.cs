using MVCPractice.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static MVCPractice.Controllers.HomeController;

namespace MVCPractice.Classes
{
    public class NinjaAction
    {
        static void Main(string[] args)
        {
            InsertNinja();
            Console.ReadKey();
        }

        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "BrandonSan",
                DateOfBirth = new DateTime(1990, 1, 15),
                ClanId = 1
            };

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }
    }
}