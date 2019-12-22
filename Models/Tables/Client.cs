using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebTattoo.Models.Tables
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        [Required]
        [DisplayName("Name")]
        public string FullName { get; set; }

        [Column(TypeName ="varchar(30)")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName ="varchar(15)")]
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNum { get; set; }


        public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
