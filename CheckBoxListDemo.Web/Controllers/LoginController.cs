using CheckBoxListDemo.Web.ViewModels.Login;
using System.Web.Mvc;

namespace CheckBoxListDemo.Web.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "admin" && model.Password == "password")
                {
                    // In a real application you would set auth cookie here
                    TempData["LoginMessage"] = "Login successful";
                    return RedirectToAction("Index", "Movie");
                }
                ModelState.AddModelError("", "Invalid username or password");
            }
            return View(model);
        }
    }
}
