using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo
{
    internal class risultato
    {
        public float latitude;
        public float longitude;
        public double generationtime_ms;
        public int utc_offset_seconds;
        public string timezone;
        public string timezone_abbreviation;
        public float elevation;
        public DailyUnits daily_units;
        public Daily daily;
    }
}

/*{
    "latitude": 41.875,
  "longitude": 12.5,
  "generationtime_ms": 0.0581741333007813,
  "utc_offset_seconds": 7200,
  "timezone": "Europe/Rome",
  "timezone_abbreviation": "GMT+2",
  "elevation": 58,
  "daily_units": {
        "time": "iso8601",
    "temperature_2m_max": "°C",
    "temperature_2m_min": "°C",
    "precipitation_sum": "mm"
  },
  "daily": {
        "time": [
          "2025-05-16",
      "2025-05-17",
      "2025-05-18",
      "2025-05-19",
      "2025-05-20",
      "2025-05-21",
      "2025-05-22"
        ],
    "temperature_2m_max": [22.7, 22.4, 22.6, 24.3, 27.7, 23.7, 22.6],
    "temperature_2m_min": [13.6, 10.8, 12.6, 13.8, 14.2, 12.9, 17.1],
    "precipitation_sum": [0, 0, 0, 0, 0, 2.1, 2.1]
  }
}*/