using System.Data.Entity;
using static MVCPractice.Controllers.HomeController;

namespace MVCPractice.App_Start
{
    public class NinjaContext : DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipments { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
    }
}