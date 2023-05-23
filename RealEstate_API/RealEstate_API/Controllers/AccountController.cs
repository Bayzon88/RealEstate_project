using Azure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate_API.Data;
using RealEstate_API.Models;
using RealEstate_API.Models.Identity;
using RealEstate_API.Models.RequestModels;
using System.Diagnostics;

namespace RealEstate_API.Controllers
{
    //Access controller by URL 
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {

        private UserManager<Users> userManager;
        private SignInManager<Users> signInManager;
        private JwtValidation jwtValidation;

        public AccountController(UserManager<Users> userManager, SignInManager<Users> signInManager, JwtValidation jwtValidation)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.jwtValidation = jwtValidation;

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //Return all acounts whithin database
         var users = await userManager.Users.ToListAsync();
            
            return Ok(users);

        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(SignUpRequest signUpRequest)
        {
            if (ModelState.IsValid)
            {
                //Create new User, uses identity framework
                var user = new Users { UserName = signUpRequest.UserName, Email = signUpRequest.Email };
                var result = await userManager.CreateAsync(user, signUpRequest.Password);
                return Ok(result);
            }
            else
            {
                return BadRequest("the model is not valid");
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            //Get user from Database
            var result = await signInManager.PasswordSignInAsync(loginRequest.UserName, loginRequest.Password, isPersistent: true, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                
                var user = await userManager.FindByNameAsync(loginRequest.UserName);
                //Return an authorization token 
                var jwt = jwtValidation.createToken(user.Email); //Create a new jwt token
                Response.Cookies.Append("jwtToken", jwt, new CookieOptions { HttpOnly = false });//Key: jwtToken
                return Ok( new { message = "user authenticated and jwt token created"});
            }
            else
            {
                return BadRequest("User Not Found");
            }

        }


    }
}

