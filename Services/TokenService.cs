using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using RTC.Models;

namespace RTC.Services {
  public static class TokenService {
    public static string GenerateToken(User user) {
      var tokenHandler = new JwtSecurityTokenHandler();
      var secretKey = Encoding.ASCII.GetBytes(Settings.Secret);
      var tokenDescriptor = new SecurityTokenDescriptor{
        Subject = new ClaimsIdentity(new Claim[]{
          new (ClaimTypes.Name, user.Username.ToString()),
        }),
        Expires = DateTime.UtcNow.AddHours(2),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature),
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      return tokenHandler.WriteToken(token);
    }
  }
}