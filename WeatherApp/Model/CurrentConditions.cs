using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    public class Units
    {
        public string Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
    }
    public class Temperature
    {
        public Units Metric { get; set; }
        public Units Imperial { get; set; }  
    }
    public class CurrentConditions
    {
        public DateTime LocalObservationDateTime { get; set; }
        public int EpochTime { get; set; }
        public string WeatherText { get; set; }
        public int WatherIcon { get; set; }
        public bool HasPrecipitation { get; set; }
        public bool IsDayTime { get; set; }
        public Temperature Temperature { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }
    }
}
