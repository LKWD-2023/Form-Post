﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class NorthwindController : Controller
    {
        private string _connectionString = @"Data Source=.\sqlexpress;Initial Catalog=Northwnd;Integrated Security=true;";

        public ActionResult SearchProducts()
        {
            return View();
        }

        public ActionResult SearchResults(int min, int max)
        {
            NorthwindDb db = new NorthwindDb(_connectionString);
            SearchResultsViewModel vm = new SearchResultsViewModel
            {
                Products = db.GetProducts(min, max),
                Min = min,
                Max = max
            };
            return View(vm);
        }
    }
}