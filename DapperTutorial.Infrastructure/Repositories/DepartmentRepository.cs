using Dapper;
using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Infrastructure.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        DapperDbContext dbContext;
        public DepartmentRepository()
        {
            dbContext = new DapperDbContext();
        }
        public int DeleteById(int id)
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                return conn.Execute("Delete From Department Where Id= @deptId", new {deptId = id});

            }
        }

        public IEnumerable<Department> GetAll()
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                return conn.Query<Department>("Select Id, Name, Location From Department"); // Table data
            }
        }

        public Department GetById(int id)
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                return conn.QuerySingleOrDefault<Department>("Select Id, Name, Location From Department where Id = @DeptId", new { deptId = id });
            }
            // Scalar or single result
        }

        public int Insert(Department obj)
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                return conn.Execute("Insert Into Department values(@Name, @Location)", obj);
            }
        }

        public int Update(Department obj)
        {
            using (IDbConnection conn = dbContext.GetConnection())
            {
                return conn.Execute("Update Department set Name = @Name, Location = @Location where id = @Id", obj);
            }
        }
    }
}
