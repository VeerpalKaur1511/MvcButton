using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcButton.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }
        // Change the welcome method with the below code 
        //public string Welcome(string name, int numTimes = 1)
        //{
        //   return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        // again change welcome method with following code 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}