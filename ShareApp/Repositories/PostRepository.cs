using ShareApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ShareApp.Repositories
{
    public class PostRepository : IRepository
    {
        private string _connStr;
        public PostRepository(string dbName)
        {
            _connStr = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
        }

        public void Save(Models.IShareable item)
        {
            throw new NotImplementedException();
        }

        public IList<Models.IShareable> ListAll()
        {
            return new List<IShareable>();
        }
    }
}