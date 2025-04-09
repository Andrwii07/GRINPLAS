using Microsoft.AspNetCore.Mvc;
using GRINPLAS.Models;

namespace GRINPLAS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult PerfilUsuario()
        {
            var model = new UserProfileViewModel
            {
                FullName = "Tatiana Mercedes Suarez Rosas",
                Email = "tatianasuarezrosas332@gmail.com",
                LocalPhone = "22334256798",
                MobilePhone = "+51 970420050",
                Password = "123456"
            };

            return View(model);
        }
    }
}
