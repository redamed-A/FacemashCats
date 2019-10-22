using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacemashService;
using Microsoft.AspNetCore.Mvc;

namespace Facemash.Controllers
{
    public class ScoreController : Controller
    {
        private readonly IScore _iScore;

        public ScoreController(IScore iScore)
        {
            _iScore = iScore ?? throw new NullReferenceException();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}