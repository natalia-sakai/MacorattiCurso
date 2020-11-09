using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JWT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JWT.Controllers
{
    public class TokenController : Controller
    {
        //autenticação usando o JWT

        //cria o token
        //recebe informações do login
        [HttpPost]
        [Route("api/token/create")]
        //FromBody obtem as informações do login 
        public IActionResult Create([FromBody] LoginViewModel model)
        {
            //verifica o login
            if (model.Email == "natalia@gmail.com" && model.Password == "numsey")
            {
                //retorna o token gerado a partir do email
                return new ObjectResult(GenerateToken(model.Email));
            }
            return BadRequest();
        }

        //gera um token
        private string GenerateToken(string email)
        {
            var claims = new Claim[]
            {
                //define as claims 
                new Claim(ClaimTypes.Name, email),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            };

            //gera o token criptografado
            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("senhasupersecretaparaauth"));
            SigningCredentials signingCredential = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            JwtHeader jwtHeader = new JwtHeader(signingCredential);
            JwtPayload jwtPayload = new JwtPayload(claims);
            JwtSecurityToken token = new JwtSecurityToken(jwtHeader, jwtPayload);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
