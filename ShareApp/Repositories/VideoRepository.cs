using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareApp.Repositories
{
    public class VideoRepository : IRepository
    {
        private string _connStr;
        public VideoRepository(string connStr)
        {
            _connStr = connStr;
        }

        public void Save(Models.IShareable item)
        {
            throw new NotImplementedException();
        }


        public IList<Models.IShareable> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}