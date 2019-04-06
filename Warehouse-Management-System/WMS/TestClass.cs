using NUnit.Framework;
using WMS.Business;
using WMS.Data;
using WMS.Data.Models;
namespace WMS
{

    [TestFixture]
    public class TestClass
    {

        [TestCase]
        public void GetItem(int id)
        {
            Item item = new Item("Gold Ingot", "03052018", 15000, null, 310, 5);
            EmployeeController employee = new EmployeeController();
            Assert.AreEqual(employee.GetItem(24), item);
        }
        [TestCase]
        public void GetItemID(string itemname)
        {
            Item item = new Item("Gold Ingot", "03052018", 15000, null, 310, 5);
            EmployeeController employee = new EmployeeController();
            Assert.AreEqual(employee.GetItemId(itemname), item.Name_Of_Item);
        }

        [TestCase]
        public void GetEmployeeID(string firstName, string lastName)
        {
            Employee employee2 = new Employee("John", "Carpenter", 25, 5, 2000, "bearer");
            EmployeeController employee = new EmployeeController();
            Assert.AreEqual(employee.GetEmployeeId("John", "Carpenter"), 3);
        }
        [TestCase]
        public void GetEmployee(int id)
        {
            Employee employee2 = new Employee("John", "Carpenter", 25, 5, 2000, "bearer");
            EmployeeController employee = new EmployeeController();
            Assert.AreEqual(employee.GetEmployee(id), employee2);
        }

        [TestCase]
        public void GetFirstName(int id)
        {
            WorkerController worker = new WorkerController();
            Assert.AreEqual(worker.GetFirstName(3), "John");
        }
        [TestCase]
        public void GetLastName(int id)
        {
            WorkerController worker = new WorkerController();
            Assert.AreEqual(worker.GetLastName(3), "Carpenter");
        }
        [TestCase]
        public void GetAge(int id)
        {
            WorkerController worker = new WorkerController();
            Assert.AreEqual(worker.GetAge(3), 23);
        }
        [TestCase]
        public void GetPosition(int id)
        {
            WorkerController worker = new WorkerController();
            Assert.AreEqual(worker.Position(id), "bearer");
        }
        [TestCase]
        public void GetYearsOfService(int id)
        {
            WorkerController worker = new WorkerController();
            Assert.AreEqual(worker.YearsOfService(id), 5);
        }
        [TestCase]
        public void Getsalary(int id)
        {
            WorkerController worker = new WorkerController();
            Assert.AreEqual(worker.Salary(id), 2000);
        }
        
    }
}
