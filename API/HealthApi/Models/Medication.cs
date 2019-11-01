using System;
using System.ComponentModel.DataAnnotations;

namespace HealthApi.Models
{
    public class Medication
    {
        [Key]
        public string Name { get; set; }
        public string Doses { get; set; }
    }
}
