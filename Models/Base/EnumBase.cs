using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietnamAds_Practice.Models.Base
{
    public class EnumBase
    {
        public enum Size_UnitOfMeasureEnum
        {
            Milimeters,
            Centimeters,
            Meters
        }

        public enum Price_UnitOfMeasureEnum
        {
            VND,
            USD
        }

        public enum Ads_NatureEnum
        {
            Tĩnh,
            Động
        }
    }
}
