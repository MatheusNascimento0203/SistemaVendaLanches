using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            ViewData["Title"] = "Todos os Lanches";
           
            var lanches = _lancheRepository.Lanches;
  
            return View(lanches);            
        }

    }
}