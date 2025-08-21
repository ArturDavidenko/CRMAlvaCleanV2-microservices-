using AlvaClean.Application.DTOs;
using AlvaClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaClean.Application.Interfaces
{
    public interface IAuthService
    {
        public Task<JwtSecurityToken> LoginEmployee(LoginEmployeeModel model);

        public bool VerifyEmployeePasword(string inputPassword, string existingPasswordHash);
    }
}
