using ShareApp.Models;
using ShareApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareApp.Services
{
    public class PostService :IService
    {
        private IRepository _repoPosts;
        public PostService(IRepository postsRepository)
        {
            _repoPosts = postsRepository;
        }

        public IList<IShareable> ShowMelhores()
        {
            return _repoPosts.ListAll();
        }
    }
}