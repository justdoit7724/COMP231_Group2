using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP231_Group2
{
    public class House
    {
        public int RoomCount { get; set; }
        public int BathCount { get; set; }
        public int Size { get; set; }
        public string Region { get; set; }
        public bool Furnished { get; set; }
        public bool ParkingAvailable { get; set; }

        // !!!
        public int Price {  get; set; }
    }
}
