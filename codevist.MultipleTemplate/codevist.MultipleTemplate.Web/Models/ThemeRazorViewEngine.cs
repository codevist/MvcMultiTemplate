using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codevist.MultipleTemplate.Web.Models
{
    public class ThemeRazorViewEngine: RazorViewEngine
    {
        private readonly ThemeModel _theme;
        public ThemeRazorViewEngine(ThemeModel theme)
        {
            _theme = theme;

            base.ViewLocationFormats = new[]
            {
                _theme.Path + "/Views/{1}/{0}.cshtml",
                _theme.Path + "/Views/Shared/{0}.cshtml",
                "~/Themes/Default/Views/{1}/{0}.cshtml"
            };

            base.PartialViewLocationFormats = new[]
            {
                _theme.Path + "/Views/{1}/{0}.cshtml",
                _theme.Path + "/Views/Shared/{0}.cshtml",
                "~/Themes/Default/Views/Shared/{0}.cshtml"
            };

            base.AreaViewLocationFormats = new[]
            {
                _theme.Path + "/Views/{2}/{1}/{0}.cshtml",
                _theme.Path + "/Views/Shared/{0}.cshtml",
                "~/Themes/Default/Views/{1}/{0}.cshtml"
            };
            base.AreaPartialViewLocationFormats = new[]
            {
                _theme.Path + "/Views/{2}/{1}/{0}.cshtml",
                _theme.Path + "/Views/{1}/{0}.cshtml",
                _theme.Path + "/Views/Shared/{0}.cshtml",
                "~/Themes/Default/Views/Shared/{0}.cshtml"
            };
        }
    }
}