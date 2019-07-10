using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietnamAds_Practice.Models
{
    public class AdsForm : Entity
    {
        public AdsForm()
        {
            AdsPosts = new List<AdsPost>();
        }


        public virtual int AdsTypeId { get; set; }
        public virtual AdsType AdsType { get; set; }
        public virtual ICollection<AdsPost> AdsPosts { get; set; }
    }
}
