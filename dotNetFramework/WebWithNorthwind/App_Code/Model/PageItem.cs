using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWithNorthwind.App_Code.Model
{
    public class PageItem
    {
        public int PageNumber { get; set; }
        public string CssClass { get; set; }
        public string TextColor { get; set; }
        public string BGButton { get; set; }
    }
}