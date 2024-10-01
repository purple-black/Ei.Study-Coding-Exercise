using System;
using System.Collections.Generic;

namespace DatabaseConnectionPoolNamespace
{
    public sealed class DatabaseConnectionPool
    {
        private static DatabaseConnectionPool _instance = null;
        private static readonly object _lock = new object();
        private Queue<DatabaseConnection> _connectionPool;

        private readonly int _maxConnections = 3;
        private int _currentConnections = 0;

        private DatabaseConnectionPool()
        {
            _connectionPool = new Queue<DatabaseConnection>();
        }

        public static DatabaseConnectionPool GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnectionPool();
                    }
                }
            }
            return _instance;
        }

        public DatabaseConnection GetConnection()
        {
            lock (_lock)
            {
                if (_connectionPool.Count > 0)
                {
                    return _connectionPool.Dequeue();
                }
                else if (_currentConnections < _maxConnections)
                {
                    var newConnection = new DatabaseConnection();
                    _currentConnections++;
                    return newConnection;
                }
                else
                {
                    throw new Exception("No available database connections. Please wait.");
                }
            }
        }

        public void ReleaseConnection(DatabaseConnection connection)
        {
            lock (_lock)
            {
                _connectionPool.Enqueue(connection);
                Console.WriteLine($"Connection {connection.ConnectionId} released back to the pool.");
            }
        }
    }
}
