using Microsoft.AspNetCore.Mvc;
using Diary_Webapp.Data; //this is a namespace for the data context

using Diary_Webapp.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Diary_Webapp.Controllers //this is a namespace for the controller
{
    public class DiaryEntriesController:Controller

    {
       
        private readonly ApplicationDbContex _db;

        public DiaryEntriesController(ApplicationDbContex db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
           List<DiaryEntry> objDiaryEntryList= _db.DiaryEntry.ToList();
            return View(objDiaryEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {

            _db.DiaryEntry.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.DiaryEntry.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {

            _db.DiaryEntry.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.DiaryEntry.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {

            _db.DiaryEntry.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}

