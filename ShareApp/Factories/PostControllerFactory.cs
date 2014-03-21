using ShareApp.Controllers;
using ShareApp.Services;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareApp.Factories
{
    public class PostControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            var id = requestContext.RouteData.Values["id"];

            if(id != null && id.ToString() == "1")
            {
                return new VideoController(ObjectFactory.GetInstance<IService>());
            }

            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}