using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;

namespace DapperTutorial.UI
{
    public class ManageDepartment
    {
        // Dependancy Injection
        DepartmentRepository department;
        public ManageDepartment()
        {
            department = new DepartmentRepository();
        }

        private void AddDepartment()
        {
            Department d = new Department();
            Console.Write("Enter Name of Department: ");
            d.Name = Console.ReadLine();
            Console.Write("Enter Location of Department: ");
            d.Location = Console.ReadLine();

            if (department.Insert(d) > 0)
            {
                Console.WriteLine("Successfully Inserted");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void UpdateDepartment()
        {
            Department d = new Department();
            Console.Write("Enter Id of Department: ");
            d.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name of Department: ");
            d.Name = Console.ReadLine();
            Console.Write("Enter Location of Department: ");
            d.Location = Console.ReadLine();
            
            if (department.Update(d) > 0)
            {
                Console.WriteLine("Successfully Updated");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void RemoveDepartment()
        {
            Console.Write("Enter Id of Department: ");
            int Idontknowwhattocallthis = Convert.ToInt32(Console.ReadLine());

            department.DeleteById(Idontknowwhattocallthis);
        }

        private void GetAllDepartment()
        {
            IEnumerable<Department> departments = department.GetAll();
            foreach (var dep in departments)
            {
                Console.WriteLine(dep.Id + "\t" + dep.Name + "\t" + dep.Location);
            }
        }

        private void GetDepartment()
        {
            Console.Write("Enter Id of Department: ");
            int getDept= Convert.ToInt32(Console.ReadLine());

            Department d = department.GetById(getDept);
            Console.WriteLine(d.Id + "\t" + d.Name + "\t" + d.Location);
        }

        public void Run()
        {

            AddDepartment();
            //GetAllDepartment();
            //Console.WriteLine("Exhibits nothing");
            //Console.ReadKey();
        }
    }
}

