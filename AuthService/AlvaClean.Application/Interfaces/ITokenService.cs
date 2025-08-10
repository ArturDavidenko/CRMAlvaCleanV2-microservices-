using AlvaClean.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlvaClean.Application.Interfaces
{
    public interface ITokenService
    {
        public Task<JwtSecurityToken> GenerateJWTToken(Employee employeer);
    }
}
