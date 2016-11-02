using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.SqlServer.Server;
using System.Data.Entity;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using MVCPractice.Classes;
using MVCPractice.App_Start;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your application home page.";
            InsertNinja();
            InsertMultipleNinjas();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public class Ninja
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Clan Clan { get; set; }
            public int ClanId { get; set; }
            public List<NinjaEquipment> OwnedEquipments { get; set; }
            public DateTime DateOfBirth { get; set; }
        }

        public class Clan
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public List<Ninja> Ninjas { get; set; }
        }

        public class NinjaEquipment
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public EquipmentType Type { get; set; }
            [Required]
            public Ninja Ninja { get; set; }
        }

        public class Enemy
        {
            public int Id { get; set; }
            public string Name { get; set; }

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
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }
        }

        private static void InsertMultipleNinjas()
        {
            var ninja1 = new Ninja
            {
                Name = "Raphael",
                DateOfBirth = new DateTime(1990, 2, 25),
                ClanId = 1
            };

            var ninja2 = new Ninja
            {
                Name = "Donatello",
                DateOfBirth = new DateTime(1990, 2, 25),
                ClanId = 1
            };

            var ninja3 = new Ninja
            {
                Name = "Michelangelo",
                DateOfBirth = new DateTime(1990, 2, 25),
                ClanId = 1
            };

            var ninja4 = new Ninja
            {
                Name = "Leonardo",
                DateOfBirth = new DateTime(1990, 2, 25),
                ClanId = 1
            };
            using (var context = new NinjaContext())
            {
                context.Ninjas.AddRange(new List<Ninja> { ninja1, ninja2, ninja3, ninja4 });
                context.SaveChanges();
            }
        }
    }
}