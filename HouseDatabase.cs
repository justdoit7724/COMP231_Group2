using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP231_Group2
{
    class HouseDatabase
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
            // deserialize & load data here
        }

        public List<House> GetData()
        {
            return m_data;
        }

    }
}
