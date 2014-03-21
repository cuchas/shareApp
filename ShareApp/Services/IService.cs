using ShareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareApp.Services
{
    public interface IService
    {
        IList<IShareable> ShowMelhores();
    }
}