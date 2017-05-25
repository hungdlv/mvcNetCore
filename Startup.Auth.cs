// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Logging;
// using mvcApp.Data;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
// using Microsoft.IdentityModel.Tokens;
// using System.Text;

// namespace mvcApp
// {
//     public partial class Startup
//     {
//         public SymmetricSecurityKey signingKey;
//         private void ConfigureAuth(IApplicationBuilder app)
//         {

//             var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("TokenAuthentication:SecretKey").Value));


//             var tokenValidationParameters = new TokenValidationParameters
//             {
//                 // The signing key must match!
//                 ValidateIssuerSigningKey = true,
//                 IssuerSigningKey = signingKey,
//                 // Validate the JWT Issuer (iss) claim
//                 ValidateIssuer = true,
//                 ValidIssuer = Configuration.GetSection("TokenAuthentication:Issuer").Value,
//                 // Validate the JWT Audience (aud) claim
//                 ValidateAudience = true,
//                 ValidAudience = Configuration.GetSection("TokenAuthentication:Audience").Value,
//                 // Validate the token expiry
//                 ValidateLifetime = true,
//                 // If you want to allow a certain amount of clock drift, set that here:
//                 ClockSkew = TimeSpan.Zero
//             };


//             app.UseJwtBearerAuthentication(new JwtBearerOptions
//             {
//                 AutomaticAuthenticate = true,
//                 AutomaticChallenge = true,
//                 TokenValidationParameters = tokenValidationParameters
//             });

//         }

//     }
// }