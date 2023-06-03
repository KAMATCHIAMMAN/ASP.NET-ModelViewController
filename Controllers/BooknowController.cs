using Microsoft.AspNetCore.Mvc;
using ModelViewController.Models;

namespace ModelViewController.Controllers
{
    public class BooknowController : Controller
    {
 
        /// view data
       
        //[ViewData]
        //public string title { get; set; }
        public IActionResult Index()
        {
            //var hotels = new List<Booknow>
            //{
            //    new Booknow{ hotelname="ks hotel",amount=3000},
            //    new Booknow{ hotelname="abc hotel",amount=5000}
            //};
            //ViewData["hotels"] = hotels;
            /// title = "kamatchi";


            /// view bag

            // ViewBag.hotel = hotels;
            //ViewData["names"] = "hello";

            var hoteldetails = new Booknow
            {
                hotelname = "ks hotel",
                amount = 5000
            };

            return View(hoteldetails);
        }

        public  IActionResult Login()
        {
            return View();
        }
    }
}
