using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab5.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Name_Service { get; set; }
        [Required]
        public int Sum { get; set; }
        [Required]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
