using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietnamAds_Practice.Models.Base
{
    public static class ConstantData
    {
        public static List<string> Price_UnitOfMeasure;
        public static List<string> Ads_Nature;
        public static List<string> Size_UnitOfMeasure;

        static ConstantData()
        {
            Price_UnitOfMeasure = new List<string> { "VND", "USD" };
            Ads_Nature = new List<string> { "Tĩnh", "Động" };
            Size_UnitOfMeasure = new List<string> { "Milimeters", "Centimeters", "Meters" };
        }
    }
}
