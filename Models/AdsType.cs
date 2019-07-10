using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietnamAds_Practice.Models
{
    public class AdsType : Entity
    {
        public AdsType()
        {
            AdsForms = new List<AdsForm>();
        }

        public virtual ICollection<AdsForm> AdsForms { get; set; }
    }
}
