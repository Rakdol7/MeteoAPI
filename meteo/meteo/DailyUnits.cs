using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo
{
    internal class DailyUnits
    {
        public string time;//time come l'attributo del JSON string perchè il valore è tra ""
        public string temperature_2m_max;
        public string temperature_2m_min;
        public string precipitation_sum;
    }
}
