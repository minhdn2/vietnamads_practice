using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VietnamAds_Practice.Models;

namespace VietnamAds_Practice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VietnamAds_Practice.Models.AdsVendor> AdsVendor { get; set; }
        public DbSet<VietnamAds_Practice.Models.AdsForm> AdsForm { get; set; }
        public DbSet<VietnamAds_Practice.Models.AdsType> AdsType { get; set; }
        public DbSet<VietnamAds_Practice.Models.AdsPost> AdsPost { get; set; }
    }
}
