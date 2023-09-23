using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Aljay Javier", StudentId = "21-1480", StudentAge = "20" },
            new StudentInfoModel { Name = "Jinalyn Javier", StudentId = "21-1481", StudentAge = "37" },
            new StudentInfoModel { Name = "Aldwin Javier", StudentId = "21-1482", StudentAge = "39" }
        };

        return View(studentInfoArray);
    }
}
