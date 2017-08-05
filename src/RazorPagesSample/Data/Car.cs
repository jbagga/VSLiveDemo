using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSample.Data
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string Make{ get; set; }

        [Required]
        public string Model{ get; set; }
    }
}
