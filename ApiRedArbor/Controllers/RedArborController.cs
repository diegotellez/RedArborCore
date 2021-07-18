using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRedArbor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RedArborController : Controller
    {
        // GET: RedArborController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RedArborController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: RedArborController/Create
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public bool Post(dynamic value)
        //{
        //    return value == null;
        //}

        // POST: RedArborController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RedArborController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RedArborController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RedArborController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RedArborController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
