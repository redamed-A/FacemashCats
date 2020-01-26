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
        private readonly IScoreService _iScore;

        public ScoreController(IScoreService iScore)
        {
            _iScore = iScore ?? throw new NullReferenceException();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}