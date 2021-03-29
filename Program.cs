using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


//using System.Web.Mvc. Name.Controllers
//{

   // using Microsoft.AspNetCore.Mvc;

   // [Route("api/[controller]")]
   // [ApiController]
   // public class NameController : ControllerBase
    //{
      //  [HttpGet]
        //public async Task<IActionResult> Get()
       // {
            
            //return Ok();
       // }
   // }
//}
namespace Movies
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Menu.Choice();

            Series series = new Series()
        {
            ID = 1,
            Title = "Spidy",
            Season = "two"

        };
            string strResultJson = JsonConvert.SerializeObject(series);
            File.WriteAllText(@"movies.json",strResultJson);
            Console.WriteLine("Stored");

            strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"movies.json");
            Series finalView = JsonConvert.DeserializeObject<Series>(strResultJson);
            Console.WriteLine(finalView.ToString());
            
        }
    
       // Public Class HomeController

//        Inherits System.Web.Mvc.Controller 

       // Private _db As New MoviesDBEntities() 

        //Function Index() As ActionResult

          //  Return View(_db.MovieSet.ToList())

       // End Function

   // End Class
    }

    internal class Series
    {
        public string Title { get; set; }
        public string Season { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return string.Format("Series Info:\n\tID: {0}, \n\tTitle: {1}, \n\tSeason: {3}, ", ID, Title, Season);
        }


             
        
    }
}
