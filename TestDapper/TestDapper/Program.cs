using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using TestDapper;



//this code goes to the appsettings.json file to get the connection info
var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

//this code finalizes the above code to setup our connection located in appsettings
string connString = config.GetConnectionString("DefaultConnection");
//creates the connection to mysql
IDbConnection conn = new MySqlConnection(connString);

var repo = new DepartmentRepository(conn);

//this query the database to get the departments
var departments = repo.GetAllDepartments();

foreach (var dept in departments)
{
    Console.WriteLine($"{dept.DepartmentID} {dept.Name}");
}