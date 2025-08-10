using AlvaClean.Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaClean.Infrastructure.Persistence
{
    public class MongoDbContext
    {
        public readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<Employee> Employeers => _database.GetCollection<Employee>("employeers");


    }
}
