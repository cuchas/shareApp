using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareApp.Models
{
    public interface IShareable
    {
        string Titulo { get; set; }
        string Texto { get; set; }
    }
}