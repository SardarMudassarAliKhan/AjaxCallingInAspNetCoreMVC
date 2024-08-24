using AjaxCallingInAspNetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AjaxCallingInAspNetCoreMVC.Data
{
    public class FleetManagementContext : DbContext
    {
        public FleetManagementContext(DbContextOptions<FleetManagementContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
   
}
