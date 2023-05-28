using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSearch
{
    public class SearchParams
    {
        public string Mark { get; set; }
        public string BodyType { get; set; }
        public string GearType { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public string Wheel { get; set; }
        public ulong PriceFrom { get; set; }
        public ulong PriceTo { get; set; }
        public uint PowerFrom { get; set; }
        public uint PowerTo { get; set; }
    }
}
