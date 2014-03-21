using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareApp.Models
{
    public class Post : IShareable
    {
        public string Titulo { get; set; }
        public string Texto { get; set; }
    }
}