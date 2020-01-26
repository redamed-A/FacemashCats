using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FacemashService;

namespace FacemashWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : Controller
    {
        private readonly IVoteService _vote;

        public VoteController(IVoteService vote)
        {
            _vote = vote ?? throw new NullReferenceException();
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _vote.ReadAllAsync();
            return View();
        }
        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    _vote.ReadAllAsync();
        //    return new string[] { "value1", "value2" };
        //}
        // GET: Vote
        public ActionResult Index()
        {
            _vote.ReadAllAsync();
            return null;
        }

        //// GET: Vote/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Vote/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Vote/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Vote/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Vote/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Vote/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Vote/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}