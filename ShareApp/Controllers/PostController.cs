using ShareApp.Services;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareApp.Controllers
{
    public class PostController : Controller
    {
        public ViewResult Index() //Comum
        {
            var postService = ObjectFactory.GetInstance<IService>();
            var itens = postService.ShowMelhores();

            return View(itens);
        }
    }
}