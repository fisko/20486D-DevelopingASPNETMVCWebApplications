﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShirtStoreWebsite.Models;

namespace ShirtStoreWebsite.Controllers
{
    public class ShirtController : Controller
    {
        private readonly Data.ShirtContext _context;

        public ShirtController(Data.ShirtContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Shirts.ToList());
        }

        public IActionResult AddShirt(Shirt shirt)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }
    }
}