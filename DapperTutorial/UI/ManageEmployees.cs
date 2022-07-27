using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.UI
{
    public class ManageEmployees
    {
        EmployeeRepository employee;
        public ManageEmployees()
        {
            employee = new EmployeeRepository();
        }

        private void AddEmployee()
        {
            Employee e = new Employee();
            Console.Write("Enter Name of Employee: ");
            d.Name = Console.ReadLine();
            Console.Write("Enter Location of Employee: ");
            d.Location = Console.ReadLine();

            if (Employee.Insert(e) > 0)
            {
                Console.WriteLine("Successfully Inserted");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void UpdateEmployee()
        {
            Employee d = new Employee();
            Console.Write("Enter Id of Employee: ");
            d.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name of Employee: ");
            d.Name = Console.ReadLine();
            Console.Write("Enter Location of Employee: ");
            d.Location = Console.ReadLine();

            if (Employee.Update(d) > 0)
            {
                Console.WriteLine("Successfully Updated");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void RemoveEmployee()
        {
            Console.Write("Enter Id of Employee: ");
            int Idontknowwhattocallthis = Convert.ToInt32(Console.ReadLine());

            Employee.DeleteById(Idontknowwhattocallthis);
        }

        private void GetAllEmployee()
        {
            IEnumerable<Employee> Employees = Employee.GetAll();
            foreach (var dep in Employees)
            {
                Console.WriteLine(dep.Id + "\t" + dep.Name + "\t" + dep.Location);
            }
        }

        private void GetEmployee()
        {
            Console.Write("Enter Id of Employee: ");
            int getDept = Convert.ToInt32(Console.ReadLine());

            Employee d = Employee.GetById(getDept);
            Console.WriteLine(d.Id + "\t" + d.Name + "\t" + d.Location);
        }

        public void Run()
        {

            AddEmployee();
            //GetAllEmployee();
            //Console.WriteLine("Exhibits nothing");
            //Console.ReadKey();
        }
    }
}
