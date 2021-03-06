﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AuthorizedController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return Content($"Authorized as {User.Identity.Name}");
        }

        [Authorize(Policy = "SqlServerJobViewer")]
        public IActionResult SqlServerJobViewer()
        {
            return Content($"Sql Server JobViewer: Authorized as {User.Identity.Name}");
        }
    }
}