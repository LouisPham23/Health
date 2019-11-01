using System.Collections.Generic;

namespace HealthApi.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public ICollection<Ailment> Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }
}