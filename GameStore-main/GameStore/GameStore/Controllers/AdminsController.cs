using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameStore.Data;
using GameStore.Models.Admin;

namespace GameStore.Controllers
{
    public class AdminsController : Controller
    {
        private readonly GameStoreContext _context;

        public AdminsController(GameStoreContext context)
        {
            _context = context;
        }
        public ActionResult Index() { 
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }
    }
}