using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerLib
{
    public static class HospitalExtentionSeeding
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Console.WriteLine("DB seeding...");
            Patient p1 = new Patient { PatientID = 1, Firstname = "Celi", Lastname = "Mommy", SVNR = 1234260204 };
            Patient p2 = new Patient { PatientID = 2, Firstname = "Peter", Lastname = "Pflaster", SVNR = 1111260205 };
            Patient p3 = new Patient { PatientID = 3, Firstname = "Verena", Lastname = "Verband", SVNR = 1233260204 };
            Patient p4 = new Patient { PatientID = 4, Firstname = "Susi", Lastname = "Sorglos", SVNR = 1231260204 };

            modelBuilder.Entity<Patient>().HasData(p1);
            modelBuilder.Entity<Patient>().HasData(p2);
            modelBuilder.Entity<Patient>().HasData(p3);
            modelBuilder.Entity<Patient>().HasData(p4);

            Doctor d1 = new Doctor { DoctorID = 1, Firstname = "Hans", Lastname = "Hausarzt" };
            Doctor d2 = new Doctor { DoctorID = 2, Firstname = "Otto", Lastname = "Ohrenarzt" };
            Doctor d3 = new Doctor { DoctorID = 3, Firstname = "Zenzi", Lastname = "Zahnarzt" };

            modelBuilder.Entity<Doctor>().HasData(d1);
            modelBuilder.Entity<Doctor>().HasData(d2);
            modelBuilder.Entity<Doctor>().HasData(d3);

            modelBuilder.Entity<Examination>().HasData(new Examination
            {
                ExaminationID = 1,
                Description = "Extraktion OR2",
                ExaminationPatientID = p2.PatientID,
                // ExaminationPatient = p1, // Don't do this
                ExaminationDoctorID = d3.DoctorID,
                // ExaminationDoctor = d3 // Don't do this
            });

            modelBuilder.Entity<Examination>().HasData(new Examination
            {
                ExaminationID = 2,
                Description = "Bruch Schienbein",
                ExaminationPatientID = p1.PatientID,
                // ExaminationPatient = p1, // Don't do this
                ExaminationDoctorID = d1.DoctorID,
                // ExaminationDoctor = d3 // Don't do this
            });
        }
    }
}
