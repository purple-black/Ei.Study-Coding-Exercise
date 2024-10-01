using System;

namespace DatabaseConnectionPoolNamespace
{
    public class DatabaseConnection
    {
        public string ConnectionId { get; private set; }

        public DatabaseConnection()
        {
            ConnectionId = Guid.NewGuid().ToString();
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing query on connection {ConnectionId}: {query}");
        }
    }
}
