using ShareApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareApp.Controllers
{
    public class VideoController : Controller
    {
        private IService _service;
        public VideoController(IService service)
        {
            _service = service;
        }

        public ViewResult Index()
        {
            var videos = _service.ShowMelhores();
            return View("videos");
        }
    }
}