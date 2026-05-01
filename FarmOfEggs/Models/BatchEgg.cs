using System;

namespace FarmOfEggs.Models
{
    public class BatchEgg
    {
        public int BatchEggID { get; set; }
        public int BirdGroupID { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public DateTime DateProduced { get; set; }
        public DateTime? BestByDate { get; set; } // Nullable to match DB
        public string Grade { get; set; }
        public string EggColor { get; set; }
    }
}
