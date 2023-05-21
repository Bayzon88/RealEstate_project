using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate_API.Data;
using RealEstate_API.Models;
using RealEstate_API.Models.RequestModels;

namespace RealEstate_API.Controllers
{
    //Access controller by URL 
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly MyLesseeDBContext myLesseeDBContext;
        private UserManager<Account> accountManager;
        private SignInManager<Account> signInManager;
        public AccountController(MyLesseeDBContext myLesseeDBContext)
        {
            this.myLesseeDBContext = myLesseeDBContext;
        }

        [HttpGet(Name = "Alvaro")]
        public IEnumerable<Account> Get()
        {

            //Return all acounts whithin database
            return myLesseeDBContext.Accounts.ToList();

            //Another way to send the list as response could be using return type as IActionResult and sending the list as a parameter of Ok() function

        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpRequest signUpRequest)
        {
            if (ModelState.IsValid)
            {
                //Validate if user exists 
                var emailIsInUse = myLesseeDBContext.Accounts.Where(user => user.Email == signUpRequest.Email).ToList().Count > 0;

                if (!emailIsInUse) //user not registered yet
                {

                    //Create new account object
                    var account = new Account()
                    {
                        AcctId = Guid.NewGuid(),
                        Email = signUpRequest.Email,
                        Password = signUpRequest.Password,
                        Phone = signUpRequest.Phone,
                        Name = signUpRequest.Name,
                        Gender = signUpRequest.Gender,
                        CreationTime = DateTime.Now,
                        LastLoginTime = DateTime.Now

                    };
                    //Add to database, save and return status 200
                    await myLesseeDBContext.AddAsync(account);
                    await myLesseeDBContext.SaveChangesAsync();
                    return Ok(account);

                }
                else
                {
                    return BadRequest("User Already exists");
                }

            }
            else
            {
                return BadRequest();
            }



        }


        //TODO: Add authentication
        [HttpPut]
        public async Task<IActionResult> UpdateAccount(UpdateAccountRequest updateAccountRequest)
        {
            if (ModelState.IsValid)
            {
                //Validate if user exists 
                var userExists = myLesseeDBContext.Accounts.Where(user => user.Email == updateAccountRequest.Email).ToList().Count > 0;

                if (userExists)
                {

                    //Create new account object
                    var account = new Account()
                    {

                        Email = updateAccountRequest.Email,
                        Password = updateAccountRequest.Password,
                        Phone = updateAccountRequest.Phone,
                        Name = updateAccountRequest.Name,
                        Gender = updateAccountRequest.Gender,

                    };
                    //Add to database, save and return status 200
                    await myLesseeDBContext.AddAsync(account);
                    await myLesseeDBContext.SaveChangesAsync();
                    return Ok(account);

                }
                else
                {
                    return BadRequest("User Already exists");
                }


            }
            else
            {
                return BadRequest();
            }
        }

        //TODO: Add authentication
        [HttpDelete]
        public async Task<IActionResult> DeleteAccount(string email)
        {
            if (ModelState.IsValid)
            {
                var account = myLesseeDBContext.Accounts.Where(user => user.Email == email).ToList().First();

                //Validate if user exists based on email
                var userExists = myLesseeDBContext.Accounts.Where(user => user.Email == email).ToList().Count > 0;

                if (userExists)
                {
                    myLesseeDBContext.Accounts.Remove(account);
                    await myLesseeDBContext.SaveChangesAsync();
                    return Ok();
                }else
                {
                    return NotFound("User Not Found!");
                }
            }
            else
            {
                return BadRequest();
            }
        }





    }
}

