using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WMS.Business
{
    public class SupervisorController : EmployeeController
    {
       
        public SupervisorController()
        {
        }
        //Принципно съм съгласен да намалим броя на overload-ите на UpdateItem.
        public void UpdateItem(int Id, decimal Price, int Quantity)
        {
            var item = base.context.Items.FirstOrDefault(x=>x.Item_Id==Id);
            item.Price = Price;
            item.Quantity = Quantity;
            base.context.SaveChanges();
        }
        //To be continued...


    }
}
