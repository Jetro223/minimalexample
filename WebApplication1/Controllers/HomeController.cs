using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MyModel
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public List<string> StringListe { get; set; }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new MyModel
            {
                Number = 1,
                Text = "Hallo",
                StringListe = new List<string> {"eins", "zwei", "drei"} //wird nur in der Partial View verwendet
            };
            return View(model);
        }

        public IActionResult GetList()
        {
            //Partial Views können auch "ganz normal" zurückgegeben werden bspw. für einen AJAX-Request
            var model = new List<string>();
            return View("_ListPartial", model);
        }
    }
}
