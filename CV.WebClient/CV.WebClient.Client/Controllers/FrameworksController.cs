﻿namespace CV.WebClient.Client.Controllers
{
    using System.Web.Mvc;

    public class FrameworksController : Controller
    {
        [Route("Frameworks/{id:int}")]
        public ActionResult GetById(int id)
        {
            ViewBag.FrameworkId = id;

            return View();
        }
    }
}