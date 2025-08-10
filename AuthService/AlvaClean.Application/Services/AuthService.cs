using AlvaClean.Application.DTOs;
using AlvaClean.Application.Interfaces;
using AlvaClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlvaClean.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly IEmployeeRepository _employeeRepository;

        public AuthService(ITokenService tokenService, IEmployeeRepository employeeRepository)
        {
            _tokenService = tokenService;
            _employeeRepository = employeeRepository;
        }

        public async Task<JwtSecurityToken> LoginEmployee(LoginEmployeeModel model)
        {
            var employee = await _employeeRepository.GetEmployeeByLastNameAsync(model.EmployeerLastName);

            if (employee == null || !VerifyEmployeePasword(model.EmployeerPassword, employee.PasswordHash))
                throw new Exception("Invalid credentials");

            return await _tokenService.GenerateJWTToken(employee);
        }

        public bool VerifyEmployeePasword(string inputPassword, string existingPasswordHash)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, existingPasswordHash);    
        }
    }
}
