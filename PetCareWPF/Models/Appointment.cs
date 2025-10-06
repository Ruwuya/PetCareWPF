using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCareWPF.Enums;

namespace PetCareWPF.Model
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public int StaffId { get; set; }
        public int TreatmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Notes { get; set; }
        public AppointmentStatus Status { get; set; }
        /* Incase i will need it
        public Staff Staff { get; set; }
        public Treatment Treatment { get; set; }
        */

    }
}
