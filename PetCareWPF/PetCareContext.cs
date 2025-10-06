using Microsoft.EntityFrameworkCore;
using PetCareWPF.Model;
using PetCareWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareWPF
{
    internal class PetCareContext : DbContext
    {
        DbSet<Appointment> Appointments { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<Medication> Medications { get; set; }
        DbSet<Pet> Pets { get; set; }
        DbSet<Species> Species { get; set; }
        DbSet<SpeciesMedication> SpeciesMedications { get; set; }
        DbSet<SpeciesTreatment> SpeciesTreatments { get; set; }
        DbSet<Staff> Staffs { get; set; }
        DbSet<Treatment> Treatments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PetCare;UID=petcare;PWD=password;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}