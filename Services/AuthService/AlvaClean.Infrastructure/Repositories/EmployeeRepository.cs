using AlvaClean.Application.Interfaces;
using AlvaClean.Domain.Entities;
using AlvaClean.Infrastructure.Models;
using AlvaClean.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AlvaClean.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly MongoDbContext _context;

        public EmployeeRepository(IOptions<MongoSettings> options)
        {
            _context = new MongoDbContext(options.Value.MongoUrl, options.Value.MongoDbName);
        }

        public async Task<Employee?> GetEmployeeByLastNameAsync(string lastName)
        {
            return _context.Employeers.Find(e => e.LastName == lastName).SingleOrDefault();
        }
    }
}
