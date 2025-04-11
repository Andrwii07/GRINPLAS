using Microsoft.AspNetCore.Mvc;
using GRINPLAS.Models;

namespace GRINPLAS.Controllers
{
    public class AccountController : Controller
    {
        // GET: Retorna el perfil como un parcial
        public IActionResult ProfilePartial()
        {
            var model = new UserProfileViewModel
            {
                FullName = "Tatiana Mercedes Suarez Rosas",
                Email = "tatianasuarezrosas332@gmail.com",
                LocalPhone = "22334256798", 
                MobilePhone = "+51 970420050",
                Password = "123456" // En producción, nunca almacenes o pases contraseñas en texto plano
            };
            
            return PartialView("_ProfileDropdown", model);
        }
        
        // POST: Account/UpdateProfile
        [HttpPost]
        public IActionResult UpdateProfile(UserProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Actualizar el perfil del usuario en tu base de datos
                // Para demo, simplemente redirigiremos de vuelta al perfil
                
                // Agregar mensaje de éxito
                TempData["SuccessMessage"] = "Perfil actualizado con éxito";
                
                return RedirectToAction("Index", "Home");
            }
            
            return PartialView("_ProfileDropdown", model);
        }
        
        // POST: Account/Logout
        [HttpPost]
        public IActionResult Logout()
        {
            // Cerrar sesión del usuario (si estás usando Identity)
            // HttpContext.SignOutAsync();
            
            return RedirectToAction("Index", "Home");
        }
    }
}