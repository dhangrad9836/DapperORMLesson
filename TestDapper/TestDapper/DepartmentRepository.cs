using Dapper;
using System.Data;

namespace TestDapper
{
    public class DepartmentRepository : IDepartmentRepository
    {
        //built in IDBConnection interface
        private readonly IDbConnection _connection; //this is a field

        //constructor
        public DepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        //Here is where we will place the code for Dapper
        public IEnumerable<Department> GetAllDepartments()
        {
            //the .Query is our Dapper method
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }
    }
}
