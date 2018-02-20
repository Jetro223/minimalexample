using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DataModel
    {
        public int Id {get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class AjaxController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SaveData(DataModel model)
        {
            return View("_DataSaved", model);
        }

        public object GetData()
        {
            var obj = new {Eins = 1, Zwei = 2, Drei = 3, Vier = 4};
            return obj;
        }
    }
}
