using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmOfEggs.Models
{
    public class BatchEgg
    {
        public int BatchEggID { get; set; }
        public int ChickenGroupID { get; set; }
        public string Size { get; set; }
        public DateTime DateProduced { get; set; }
        public DateTime BestByDate { get; set; }
        public string Grade { get; set; }
        public string EggColor { get; set; }
    }
}
