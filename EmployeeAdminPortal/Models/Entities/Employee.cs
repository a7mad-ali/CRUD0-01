namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {


        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? phone { get; set; }
        public decimal Salary { get; set; }

    }
}
