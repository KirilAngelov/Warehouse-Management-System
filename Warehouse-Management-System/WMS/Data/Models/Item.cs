
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WMS.Data.Models
{
   public class Item
    {
        public Item()
        {

        }
        public Item(string name,string dateAdded,decimal price,string expirationDate,int quantity
            ,int storedBy) 

        {
            this.Name_Of_Item = name;
            this.Date_Added = dateAdded;
            this.Price = price;
            this.Expiration_Date = expirationDate;
            this.Quantity = quantity;
            this.Stored_By = storedBy;
            
        }


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Item_Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name_Of_Item { get; set; }
        [Required]
        public string Date_Added { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Expiration_Date { get; set; }
        [Required]
        public int Quantity { get; set; }
        [ForeignKey("Employee")]
        public int Stored_By { get; set; }
        public Employee Employee { get; set; }

    }
}
