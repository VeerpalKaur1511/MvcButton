using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcButton.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index() // Replace the index with this code
        {
            return View();
        }
        // Change the welcome method with the below code 
        //public string Welcome(string name, int numTimes = 1)
        //{
        //   return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        // again change welcome method with following code 

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}


        //  In HelloWorldController.cs, change the Welcome method to add a Message and NumTimes value to the ViewData

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}