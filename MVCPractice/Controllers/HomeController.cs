using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.SqlServer.Server;
using System.Data.Entity;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your application home page.";

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
    }
}