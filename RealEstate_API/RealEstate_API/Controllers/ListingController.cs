using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate_API.Data;
using RealEstate_API.Migrations;
using RealEstate_API.Models;
using RealEstate_API.Models.RequestModels;

namespace RealEstate_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ListingController : Controller
    {
        private readonly MyLesseeDBContext myLesseeDBContext;
        private UserManager<Account> accountManager;
        private SignInManager<Account> signInManager;
        public ListingController(MyLesseeDBContext myLesseeDBContext)
        {
            this.myLesseeDBContext = myLesseeDBContext;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            //Show all Listings
            return Ok(await myLesseeDBContext.Listings.ToListAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> ListingDetails([FromRoute] int id)
        {
            //Get information of Listing
            var listing = myLesseeDBContext.Listings.Find(id);
            return Ok(listing);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewListing(AddListingRequest addListingRequest)
        {
            if (ModelState.IsValid)
            {
                //No need to check if other listing has the same information

                var listingsCount = myLesseeDBContext.Listings.ToList().Count;



                var listing = new Listing()
                {
                    ListingId = listingsCount + 1,
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


    }
}
