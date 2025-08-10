using AlvaClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaClean.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetEmployeeByLastNameAsync(string lastName);
    }
}
