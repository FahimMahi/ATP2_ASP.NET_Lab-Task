﻿using System.Web;
using System.Web.Mvc;

namespace Mid_Lab3_FormValidation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
