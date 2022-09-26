using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProductsInformation.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Migracion.Api.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly PropertiesSettings _settings;
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IOptions<PropertiesSettings> settings
            ) : base(options, logger, encoder, clock) {

            _settings = settings.Value;
        }


        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {

            try
            {
                if (!Request.Headers.ContainsKey("Authorization"))
                    return AuthenticateResult.Fail("Authorization header was not found");

                var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);
                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                string email = credentials[0].ToString();
                string password = credentials[1].ToString();

                if (email == _settings.UserName && password == _settings.Password)
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, email) };
                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);
                    return AuthenticateResult.Success(ticket);
                }
                else {
                    return AuthenticateResult.Fail("Invalid username or password");
                }

            }
            catch (Exception)
            {

                return AuthenticateResult.Fail("Error has ocurred");
            }
        }


    }
}
