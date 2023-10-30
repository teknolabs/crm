using System;
using TeknoLabs.Crm.Application.Abstractions;
using TeknoLabs.Crm.Domain.AppEntities.Identity;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;

namespace TeknoLabs.Crm.Infrastructure.Authentication
{
	public sealed class JwtProvider : IJwtProvider
	{
        private readonly JwtOptions _jwtOptions;
        private readonly UserManager<AppUser> _userManager;

        public JwtProvider(IOptions<JwtOptions> jwtOptions, UserManager<AppUser> userManager)
        {
            _jwtOptions = jwtOptions.Value;
            _userManager = userManager;
        }

        public async Task<string> CreateTokenAsync(AppUser user, List<string> roles)
        {
            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.NameLastName),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim(ClaimTypes.Authentication,user.Id),
                new Claim(ClaimTypes.Role,String.Join(",",roles))
            };

            DateTime expires = DateTime.Now.AddDays(1);

            JwtSecurityToken jwtSecurityToken = new(
                issuer: _jwtOptions.Issuer,
                audience: _jwtOptions.Audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: expires,
                signingCredentials: null);

            string token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            string refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpries = expires.AddDays(1);
            await _userManager.UpdateAsync(user);

            return token;
        }
    }
}

