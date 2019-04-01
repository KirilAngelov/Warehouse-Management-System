using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WMS.Data.Models
{
   public class Employee
    {
        public Employee()
        {

        }
        public Employee(string FirstName, string LastName, int Age, int YearsOfService,
            decimal Salary, string Position)
        {
            this.First_Name = FirstName;
            this.Last_Name = LastName;
            this.Age = Age;
            this.Years_Of_Service = YearsOfService;
            this.Salary = Salary;
            this.Position = Position;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Employee_Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public int Age { get;set; }
        [Required]
        public int Years_Of_Service { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public string Position { get; set; }

    }
}
