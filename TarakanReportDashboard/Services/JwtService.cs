using BitzArt.Blazor.Auth;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TarakanReportDashboard.Models;

namespace TarakanReportDashboard.Services
{
    // This service provides a basic example of how to create a JWT.
    // In a real-world scenario, you should:
    // 1. use a more secure key;
    // 2. store it in a secure location;
    // and might want to use a more secure algorithm.
    public class JwtService
    {
        private readonly SigningCredentials _signingCredentials;
        private readonly JwtSecurityTokenHandler _tokenHandler;

        public JwtService()
        {
            var key = "RsUdT4r4K4nP3m3r1nt4hDKIJ4k4rt41nd0N3si4";
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            _signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            _tokenHandler = new JwtSecurityTokenHandler();
        }

        public JwtPair BuildJwtPair(Claim[] claims)
        {
            var now = DateTime.UtcNow;

            var accessTokenDuration = new TimeSpan(hours: 0, minutes: 2, seconds: 0);
            var accessTokenExpiresAt = now + accessTokenDuration;
            //LoggedInUserModel user = new LoggedInUserModel(1, _appUser.response.userName, Model.Password);
            var accessToken = _tokenHandler.WriteToken(new JwtSecurityToken(
                claims: claims,
                notBefore: now,
                expires: accessTokenExpiresAt,
                signingCredentials: _signingCredentials
            ));

            var refreshTokenDuration = new TimeSpan(hours: 0, minutes: 3, seconds: 0);
            var refreshTokenExpiresAt = now + refreshTokenDuration;
            var refreshToken = _tokenHandler.WriteToken(new JwtSecurityToken(
                notBefore: now,
                expires: refreshTokenExpiresAt,
                signingCredentials: _signingCredentials
            ));

            return new JwtPair(accessToken, accessTokenExpiresAt, refreshToken, refreshTokenExpiresAt);
        }

        public JwtPair BuildRefreshJwtPair()
        {
            var now = DateTime.UtcNow;

            var accessTokenDuration = new TimeSpan(hours: 0, minutes: 15, seconds: 0);
            var accessTokenExpiresAt = now + accessTokenDuration;
            //LoggedInUserModel user = new LoggedInUserModel(1, _appUser.response.userName, Model.Password);
            var accessToken = _tokenHandler.WriteToken(new JwtSecurityToken(
                claims:
                [
                    new Claim("tokenType", "RefreshToken")
                ],
                notBefore: now,
                expires: accessTokenExpiresAt,
                signingCredentials: _signingCredentials
            ));

            var refreshTokenDuration = new TimeSpan(hours: 24, minutes: 0, seconds: 0);
            var refreshTokenExpiresAt = now + refreshTokenDuration;
            var refreshToken = _tokenHandler.WriteToken(new JwtSecurityToken(
                notBefore: now,
                expires: refreshTokenExpiresAt,
                signingCredentials: _signingCredentials
            ));

            return new JwtPair(accessToken, accessTokenExpiresAt, refreshToken, refreshTokenExpiresAt);
        }
    }
}
