using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab5.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Name_Order { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public DateTime Data_of_Complection { get; set; }
        [Required]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        [ForeignKey("OrderId")]
        public virtual List<Material> Material { set; get; }
    }
}
