/*
In a large-scale application, multiple parts of the system might need to access a database concurrently.
Establishing a new connection each time can be resource-intensive.
A Singleton Database Connection Pool can manage a limited number of database connections,
reusing them to optimize performance and resource management.
*/

using System;
using DatabaseConnectionPoolNamespace;
using Utilities;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DatabaseConnectionPool pool = DatabaseConnectionPool.GetInstance();
                DatabaseConnection conn1 = pool.GetConnection();
                conn1.ExecuteQuery("SELECT * FROM Users");

                DatabaseConnection conn2 = pool.GetConnection();
                conn2.ExecuteQuery("SELECT * FROM Products");

                DatabaseConnection conn3 = pool.GetConnection();
                conn3.ExecuteQuery("SELECT * FROM Orders");

                pool.ReleaseConnection(conn1);
                pool.ReleaseConnection(conn2);

                DatabaseConnection conn4 = pool.GetConnection();
                conn4.ExecuteQuery("SELECT * FROM Transactions");
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }

            Console.ReadLine();
        }
    }
}
