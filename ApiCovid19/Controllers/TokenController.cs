using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Token;

namespace ApiCovid19.Controllers
{
    public class TokenController : Controller
    {
      
        [AllowAnonymous]
        [Produces("application/json")]
        [HttpPost("/api/CreateToken")]
        public async Task<IActionResult> CreateToken([FromBody] InputModel Input)
        {
            if (string.IsNullOrWhiteSpace(Input.Email) || string.IsNullOrWhiteSpace(Input.Password))
                return Unauthorized();

            if (Input.Email == "admin" && Input.Password == "admin")
            {            
                var token = new TokenJWTBuilder()
                     .AddSecurityKey(JwtSecurityKey.Create("Secret_Key-12345678"))
                 .AddSubject("Empresa E-Commerce")
                 .AddIssuer("Teste.Securiry.Bearer")
                 .AddAudience("Teste.Securiry.Bearer")
                 .AddClaim("UsuarioAPINumero", "1")
                 .AddExpiry(60)
                 .Builder();

                return Ok(new { token.value });
            }
            else
            {
                return Unauthorized();
            }
        }

    }
}
