namespace DapperTutorial.Core.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }
        //Navigation Property .includes
        public Department? Dept { get; set; }
    }
}