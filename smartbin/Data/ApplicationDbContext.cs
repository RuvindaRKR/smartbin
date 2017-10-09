using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using smartbin.Data.Models;

namespace smartbin.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BinDetail> bindetail_tbl { get; set; }
        public DbSet<Feedback> feedback { get; set; }
        public DbSet<Workforce> workforce_tbl { get; set; }
        public DbSet<working> working_tbl { get; set; }
        public DbSet<mon> mon_binLevel_tbl { get; set; }
        public DbSet<tue> tue_binLevel_tbl { get; set; }
        public DbSet<wen> wen_binLevel_tbl { get; set; }
        public DbSet<thu> thu_binLevel_tbl { get; set; }
        public DbSet<fri> fri_binLevel_tbl { get; set; }
        public DbSet<sat> sat_binLevel_tbl { get; set; }
        public DbSet<sun> sun_binLevel_tbl { get; set; }
        public DbSet<dailyinput> dailyinput_tbl { get; set; }
        public DbSet<dailylvl> dailylvl_tbl { get; set; }
        public DbSet<monthlvl> monthlvl_tbl { get; set; }
        public DbSet<SensorCheck> sensorCheck_tbl { get; set; }
        public DbSet<sms> smsfeedback_tbl { get; set; }
        public DbSet<bindiss> bindis_tbl { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
