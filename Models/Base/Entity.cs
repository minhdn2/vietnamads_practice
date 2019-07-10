using System;
using System.ComponentModel.DataAnnotations;

namespace VietnamAds_Practice.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? UpdatedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DeletedDate { get; set; }
    }
}
