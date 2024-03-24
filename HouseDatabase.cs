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

        private List<House> m_data;

        public HouseDatabase()
        {
            m_data = new List<House>();

            GenerateSampleData();
        }

        public List<House> GetData()
        {
            return m_data;
        }

        private void GenerateSampleData()
        {
            // Toronto (Downtown)
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 800, Region = "Downtown Toronto", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1200, Region = "Financial District", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 600, Region = "Entertainment District", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 4, BathCount = 3, Size = 1500, Region = "Harbourfront", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 850, Region = "Queen Street West", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 500, Region = "King Street West", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1100, Region = "St. Lawrence Market", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 700, Region = "Yonge and Dundas", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 550, Region = "Distillery District", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1000, Region = "CityPlace", Furnished = true, ParkingAvailable = true });

            // East York
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 800, Region = "Thorncliffe Park", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1200, Region = "Leaside", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 600, Region = "Broadview North", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 4, BathCount = 3, Size = 1500, Region = "East Danforth", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 850, Region = "Crescent Town", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 500, Region = "Pape Village", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1100, Region = "O'Connor-Parkview", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 700, Region = "Woodbine Gardens", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 550, Region = "Topham Park", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1000, Region = "Parkview Hills", Furnished = false, ParkingAvailable = true });

            // York
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 800, Region = "Weston", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1200, Region = "Mount Dennis", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 600, Region = "Lambton", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 4, BathCount = 3, Size = 1500, Region = "Silverthorn", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 850, Region = "Keelesdale", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 500, Region = "Beechborough-Greenbrook", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1100, Region = "Humewood-Cedarvale", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 700, Region = "Oakwood Village", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 550, Region = "Fairbank", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1000, Region = "Briar Hill-Belgravia", Furnished = false, ParkingAvailable = true });

            // Junction
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 800, Region = "Junction Triangle", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1200, Region = "Syme", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 600, Region = "Runnymede", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 4, BathCount = 3, Size = 1500, Region = "West Toronto Junction", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 850, Region = "Lambton Baby Point", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 500, Region = "High Park North", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1100, Region = "Rockcliffe-Smythe", Furnished = false, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 2, BathCount = 1, Size = 700, Region = "Keelesdale-Eglinton West", Furnished = true, ParkingAvailable = true });
            m_data.Add(new House { RoomCount = 1, BathCount = 1, Size = 550, Region = "Weston-Pellam Park", Furnished = true, ParkingAvailable = false });
            m_data.Add(new House { RoomCount = 3, BathCount = 2, Size = 1000, Region = "Lambton Park", Furnished = false, ParkingAvailable = true });
        }
    }
}