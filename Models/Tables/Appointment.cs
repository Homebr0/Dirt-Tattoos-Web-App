using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebTattoo.Models.Tables
{
    public class Appointment
    {
        [Key]
        public int AppId { get; set; }
        public int ClientId { get; set; }
        public DateTime AppDate { get; set; }
        [Required]
        public string Comment { get; set; }

        public virtual Client Client { get; set; }
    }
}
