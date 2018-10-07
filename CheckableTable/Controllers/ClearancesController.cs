using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheckableTable.Data;
using Microsoft.AspNetCore.Mvc;

namespace CheckableTable.Controllers
{
    public class ClearancesController : Controller
    {
        private ClearancesRepository _clearancesRepository;

        public ClearancesController(ClearancesRepository clearancesRepository)
        {
            _clearancesRepository = clearancesRepository;
        }
        public IActionResult Index()
        {
            var clearances = _clearancesRepository.Get();
            return View(clearances);
        }
    }
}