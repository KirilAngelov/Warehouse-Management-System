using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WMS.Data.Models
{
    public class Client
    {
        [Key]
        public int Client_Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string First_Name { get; set; }
        [Required]
        [MaxLength(20)]
        public string Last_Name { get; set; }
        public decimal Spent_Money { get; set; }
        [Required]
        public string Is_VIP { get; set; }
    }
}
