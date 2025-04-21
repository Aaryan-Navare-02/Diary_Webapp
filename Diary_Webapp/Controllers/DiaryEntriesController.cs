using Microsoft.AspNetCore.Mvc;

namespace Diary_Webapp.Controllers //this is a namespace for the controller
{
    public class DiaryEntriesController:Controller

    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
