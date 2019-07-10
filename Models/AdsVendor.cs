using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietnamAds_Practice.Models
{
    public class AdsVendor : Entity
    {
        public AdsVendor()
        {
            AdsPosts = new List<AdsPost>();
        }

        public virtual ICollection<AdsPost> AdsPosts { get; set; }
    }
}
