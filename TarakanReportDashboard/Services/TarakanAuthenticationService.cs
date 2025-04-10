using BitzArt.Blazor.Auth;
using BitzArt.Blazor.Auth.Server;
using System.Security.Claims;

namespace TarakanReportDashboard.Services
{  
    public class TarakanAuthenticationService(JwtService jwtService)
    : AuthenticationService<SignInPayload>()
    {
        public override Task<AuthenticationResult> SignInAsync(SignInPayload signInPayload, CancellationToken cancellationToken = default)
        {
            var userId = signInPayload.UserId;
            var userName = signInPayload.UserName;
            var email = signInPayload.Email;
            Claim[] _claim = [
                new Claim("UserID", userId!),
                new Claim("UserName", userName!),
                new Claim("Email", email!)
                ];
            var jwtPair = jwtService.BuildJwtPair(_claim);
            var authResult = Success(jwtPair);

            return Task.FromResult(authResult);
        }

        public override Task<AuthenticationResult> RefreshJwtPairAsync(string refreshToken, CancellationToken cancellationToken = default)
        {
            var jwtPair = jwtService.BuildRefreshJwtPair();
            var authResult = Success(jwtPair);

            return Task.FromResult(authResult);
        }
    }
}
