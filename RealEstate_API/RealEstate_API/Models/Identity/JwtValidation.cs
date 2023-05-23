using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace RealEstate_API.Models.Identity
{
    public class JwtValidation
    {
        private string jwtKey = "placeholder_used_to_create_the_jwtkey";
        public string createToken(string email)
        {
            //Creating token 
            var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var credential = new SigningCredentials(symmetricKey,SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credential);


            var expires = DateTime.Today.AddDays(1); //Expiration date (24 hours)
            var payload = new JwtPayload(email, null, null, null,expires); //bypassing issuer, audience, etc

            var securityToken = new JwtSecurityToken(header, payload);
            return new JwtSecurityTokenHandler().WriteToken(securityToken); //Returns the security token as string

        }

        public JwtSecurityToken verifyToken(string jwtToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(jwtKey);
            tokenHandler.ValidateToken(jwtToken, new TokenValidationParameters{
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,  //Because of bypass in payload above
                ValidateAudience = false //Because of bypass in payload above
            }, out SecurityToken validatedToken );

            return (JwtSecurityToken) validatedToken;

        }
    }
}
