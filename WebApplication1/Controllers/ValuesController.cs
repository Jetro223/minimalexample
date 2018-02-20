using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly TestContext _db;

        public ValuesController(TestContext db)
        {
            _db = db;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<MyEntity> Get()
        {
            return _db.MyEntities.ToList();
        }
    }
}
