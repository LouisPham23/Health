using System;
using System.ComponentModel.DataAnnotations;

namespace HealthApi.Models
{
    public class Ailment
    {
        [Key]
        public string Name { get; set; }
    }
}
