﻿using System.Web;
using System.Web.Mvc;

namespace Practica3_BasesDeDatos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
