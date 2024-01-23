namespace Samochodzik.Models
{
    using System;

    namespace Samochodzik.Models
    {
        public class CarRepair
        {
            public int CarRepairID { get; set; }
            public string? CarModel { get; set; }
            public string? CustomerName { get; set; }
            public DateTime RepairDate { get; set; }
            public decimal Price { get; set; }
        }
    }
}
