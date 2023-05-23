using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate_API.Data;
using RealEstate_API.Migrations;
using RealEstate_API.Models;
using RealEstate_API.Models.Identity;
using RealEstate_API.Models.RequestModels;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RealEstate_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ListingController : Controller
    {
        private readonly MyLesseeDBContext myLesseeDBContext;
        private UserManager<Account> accountManager;
        private SignInManager<Account> signInManager;
        private JwtValidation jwtValidation;
        public ListingController(MyLesseeDBContext myLesseeDBContext, JwtValidation jwtValidation)
        {
            this.myLesseeDBContext = myLesseeDBContext;
            this.jwtValidation = jwtValidation;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            //Request cookie and check if user is logged in 
            var jwt = Request.Cookies["jwtToken"]; //Cookie Name in AccountController/Login 
            var token = jwtValidation.verifyToken(jwt);
            var username = token.Issuer;

            if (username == null) return BadRequest("User must be authenticated");

            //Show all Listings
            return Ok(await myLesseeDBContext.Listings.ToListAsync());
        }

        [HttpGet]
        [Route("{id:int}")]

        public async Task<IActionResult> ListingDetails([FromRoute] int id)
        {
            //Find specific listing and return for Details Page 
            var listing = myLesseeDBContext.Listings.Find(id);
            return Ok(listing);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewListing(AddListingRequest addListingRequest)
        {
            if (ModelState.IsValid)
            {
                var listing = new Listing()
                {

                    HouseType = addListingRequest.HouseType,
                    Address = addListingRequest.Address,
                    BedroomNo = addListingRequest.BedroomNo,
                    WashroomNo = addListingRequest.WashroomNo,
                    ParkingNo = addListingRequest.ParkingNo,
                    Description = addListingRequest.Description,
                    RentalPrice = addListingRequest.RentalPrice,
                    ValidDays = 30,
                    Status = true
                };
                await myLesseeDBContext.Listings.AddAsync(listing);
                await myLesseeDBContext.SaveChangesAsync();
                return Ok(listing);


            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> ModifyListing([FromRoute] int id, ModifyListingRequest modifyListingRequest)
        {
            //Modify Listing information

            Listing listing = await myLesseeDBContext.Listings.FindAsync(id);


            Listing updatedListing = listing;

            //Update Information
            updatedListing.Address = modifyListingRequest.Address;
            updatedListing.TotalArea = modifyListingRequest.TotalArea;
            updatedListing.BedroomNo = modifyListingRequest.BedroomNo;
            updatedListing.WashroomNo = modifyListingRequest.WashroomNo;
            updatedListing.ParkingNo = modifyListingRequest.ParkingNo;
            updatedListing.Description = modifyListingRequest.Description;
            updatedListing.RentalPrice = modifyListingRequest.RentalPrice;
            updatedListing.ListingTime = DateTime.Now;


            myLesseeDBContext.Listings.Update(updatedListing);
            await myLesseeDBContext.SaveChangesAsync();
            return Ok("Updated");



        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteListing([FromRoute] int id)
        {
            Listing listing = await myLesseeDBContext.Listings.FindAsync(id);
            myLesseeDBContext.Listings.Remove(listing);
            await myLesseeDBContext.SaveChangesAsync();
            return Ok("Listing deleted");
        }

    }
}
