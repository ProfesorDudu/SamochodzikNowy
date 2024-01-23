namespace Samochodzik.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using Models;

    public class CarRepairContext : DbContext
    {
        public CarRepairContext(DbContextOptions<CarRepairContext> options)
            : base(options)
        {
        }

        public DbSet<Samochodzik.Models.CarRepair> CarRepairs { get; set; }
    }
}
