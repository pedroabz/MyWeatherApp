﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeatherApp.Infrastructure.DTOs
{
    public class CityDTO
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public Location Country { get; set; }
        public Location AdministrativeArea { get; set; }

        public class Location
        {
            public string ID { get; set; }
            public string LocalizedName { get; set; }
        }
    }
}
