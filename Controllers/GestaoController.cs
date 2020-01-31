using System;
using Microsoft.AspNetCore.Mvc;

namespace CRUDCore.Controllers
{
    public class GestaoController : Controller
    {
        public IActionResult Index (){
            return View();
        }
    }
}