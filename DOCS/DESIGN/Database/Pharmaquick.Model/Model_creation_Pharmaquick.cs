using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Reef.Model

{

    public class pharmaquick : DbContext

    {

        public DbSet<Patient> Patient { get; set; }

        public DbSet<Provider> Provider { get; set; }

        public DbSet<Prescription> Prescription { get; set; }

        public DbSet<Medication> Medication { get; set; }

        public DbSet<Pharmacy> Pharmacy { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Reef-Survey;Trusted_Connection=True;");

        }

    }



    public class Patient

    {

        public int PatientID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string country { get; set; }

        public string city { get; set; }

        public int Zipcode { get; set; }

        public string Race { get; set; }

        public int ProviderID { get; set; }



    }



    public class Provider

    {

        public int providerID { get; set; }

        public string Lastname { get; set; }

        public string FirstName { get; set; }

        public string  specialty { get; set; }

        public string hospital { get; set; }

        public string country { get; set; }

        public string city { get; set; }

        public string zip { get; set; }
    }



    public class Prescription

    {

        public int providerID { get; set; }

        public int PatientID{ get; set; }

        public string NameMedication { get; set; }

        public string DatePrescription { get; set; }

        public int NumberRefill { get; set; }

        public string PharmacyName { get; set; }

        public int Quantity { get; set; }

        public string fillDate { get; set; }



        public string DistotinueDate { get; set; }

        public string Last { get; set; }


    }



    public class Medication

    {

        public string CommonName{ get; set; }

        public string GenericName { get; set; }

        public string Classification { get; set; }

        public string Regulation { get; set; }

        public string TypeMedication { get; set; }

       


    }



    public class Pharmacy

    {

        public string Name { get; set; }

        public string country { get; set; }

        public string city { get; set; }

        public int zip { get; set; }

    }
}