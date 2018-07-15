using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codevist.MultipleTemplate.Web.Models
{
    public class ThemeModel
    {
        public string Name { get; set; }
        public string BasePath { get; set; }
        public string Path { get { return String.Format("~/{0}/{1}/", BasePath, Name); } }
        public ThemeModel(string basePath, string name)
        {
            Name = name;
            BasePath = basePath;
        }
    }
}