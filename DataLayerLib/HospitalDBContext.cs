using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public class HospitalDBContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public HospitalDBContext()
        {
        }
        public HospitalDBContext(DbContextOptions<HospitalDBContext> options) :base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            Console.WriteLine($"DB OnConfiguring: IsConfigured ={optionsBuilder.IsConfigured}");
            if (optionsBuilder != null && !optionsBuilder.IsConfigured)
            {
                string conStr = @"server=(LocalDB)\mssqllocaldb;attachdbfilename=C:\Users\basti\Desktop\schule\5KL\Programmieren\B_12DataGrid\DaataGrid\DataLayerLib\HosDBGrp.mdf; database=HosDBGrp;integrated security=True;MultipleActiveResultSets=True;";

                Console.WriteLine($"Using ConnStr={conStr}");
                optionsBuilder.UseSqlServer(conStr);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }

    }
}
