using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VietnamAds_Practice.Models
{
    //enum UnitOfMeasure
    //{
    //    Milimeters,
    //    Centimeters,
    //    Meters
    //}
    public class AdsPost : Entity
    {
        public string Title { get; set; }
        public float? Price { get; set; }
        public bool Price_IsDealable { get; set;}
        public string LogoUrl { get; set; }

        //#region Size
        //public float Size_Length { get; set; }
        //public float Size_Width { get; set; }
        //public float Size_Height { get; set; }
        //public string UnitOfMeasure { get; set; }
        //#endregion Size

        public virtual int AdsFormId { get; set; }
        public virtual AdsForm AdsForm { get; set; }
        public virtual int AdsVendorId { get; set; }
        public virtual AdsVendor AdsVendor { get; set; }
        
        
    }
}
