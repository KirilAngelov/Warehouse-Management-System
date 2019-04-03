using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WMS.Data.Models
{
    public class Client
    {
        public Client()
        {

        }
        public Client(string first_Name, string last_Name, decimal spent_Money, string is_VIP)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
            Spent_Money = spent_Money;
            Is_VIP = is_VIP;
        }

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
