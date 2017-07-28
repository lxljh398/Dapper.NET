using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new SqlConnection(@"Data Source=DESKTOP-4VMU4KM\SQL2016;User Id = sa;Password = 123123;Initial Catalog=DataMip;Integrated Security=True;MultipleActiveResultSets=True");

            var result = connection.Execute("Insert into Users values (@UserName, @Email, @Address)", new { UserName = "jack", Email = "380234234@qq.com", Address = "上海" });
        }
    }
}
