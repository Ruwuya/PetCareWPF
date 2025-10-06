using PetCareWPF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCareWPF.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public char SpeciesId { get; set; }
        public string Breed { get; set; }
        public DateOnly BirthDate { get; set; }
        public Sex Sex { get; set; }
        public Customer Customer { get; set; }
        public Species Species { get; set; }
    }
}
