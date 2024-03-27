using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP231_Group2
{
    public class HouseDatabase
    {
        private static HouseDatabase m_instance = null;
        public static HouseDatabase Instance
        {
            get
            {
                if (m_instance == null)
                    m_instance = new HouseDatabase();
                return m_instance;
            }
        }

        public HouseDatabase()
        {
        }


		//Changed the return type, to make it easier to work with in the DataGrid.
		public static IEnumerable<House> GenerateSampleData()
		{
			// Toronto (Downtown)
			yield return new House { RoomCount = 2, BathCount = 1, Size = 800, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1200, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 600, Region = "Downtown Toronto", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 4, BathCount = 3, Size = 1500, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 2, BathCount = 1, Size = 850, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 500, Region = "Downtown Toronto", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1100, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 2, BathCount = 1, Size = 700, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 550, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1000, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = true };

			// East York
			yield return new House { RoomCount = 2, BathCount = 1, Size = 800, Region = "East York", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1200, Region = "East York", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 600, Region = "East York", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 4, BathCount = 3, Size = 1500, Region = "East York", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 2, BathCount = 1, Size = 850, Region = "East York", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 500, Region = "East York", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1100, Region = "East York", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 2, BathCount = 1, Size = 700, Region = "East York", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 550, Region = "East York", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1000, Region = "East York", Furnished = false, ParkingAvailable = true };

			// York
			yield return new House { RoomCount = 2, BathCount = 1, Size = 800, Region = "York", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1200, Region = "York", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 600, Region = "York", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 4, BathCount = 3, Size = 1500, Region = "York", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 2, BathCount = 1, Size = 850, Region = "York", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 500, Region = "York", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1100, Region = "York", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 2, BathCount = 1, Size = 700, Region = "York", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 550, Region = "York", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1000, Region = "York", Furnished = false, ParkingAvailable = true };

			// Junction
			yield return new House { RoomCount = 2, BathCount = 1, Size = 800, Region = "Junction", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1200, Region = "Junction", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 600, Region = "Junction", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 4, BathCount = 3, Size = 1500, Region = "Junction", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 2, BathCount = 1, Size = 850, Region = "Junction", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 500, Region = "Junction", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1100, Region = "Junction", Furnished = false, ParkingAvailable = true };
			yield return new House { RoomCount = 2, BathCount = 1, Size = 700, Region = "Junction", Furnished = true, ParkingAvailable = true };
			yield return new House { RoomCount = 1, BathCount = 1, Size = 550, Region = "Junction", Furnished = true, ParkingAvailable = false };
			yield return new House { RoomCount = 3, BathCount = 2, Size = 1000, Region = "Junction", Furnished = false, ParkingAvailable = true };
		}
	}
}