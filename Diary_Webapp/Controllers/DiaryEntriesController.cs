using Microsoft.AspNetCore.Mvc;

namespace Diary_Webapp.Controllers
{
    public class DiaryEntriesController:Controller

    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
