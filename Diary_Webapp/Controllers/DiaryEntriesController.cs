using Microsoft.AspNetCore.Mvc;
using Diary_Webapp.Data; //this is a namespace for the data context

using Diary_Webapp.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

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
    }
}
