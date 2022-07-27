using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Infrastructure.Data
{
    public class DapperDbContext
    {
        readonly string connectionString = "Data Source=.;Initial Catalog=June2022Batch;Integrated Security=True";
        IDbConnection dbConnection;
        public DapperDbContext()
        {
            // dbConnection = new SqlConnection("Data Source=.;Initial Catalog=JuneBatch;Integrated Security=True");
            //string conn = new ConfigurationBuilder().AddJsonFile("appSettings.json").Build().GetConnectionString("JuneBatch");\
            //SqlConnection secondWay = new SqlConnection(conn);
        }
        public IDbConnection GetConnection()
        {

            SqlConnection dbConnection = new SqlConnection(connectionString);
            return dbConnection; //return conn;
        }
    }
}
