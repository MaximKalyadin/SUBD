using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab5.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int Phone_Numper { get; set; }
        [ForeignKey("ClientId")]
        public virtual List<Order> Orders { set; get; }
        [ForeignKey("ClientId")]
        public virtual List<Service> Services { get; set; }
    }
}
