using ShareApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareApp.Repositories
{
    public interface IRepository
    {
        void Save(IShareable item);

        IList<IShareable> ListAll();
    }
}