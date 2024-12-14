using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.BLL;

namespace Parcial4.Controllers.Users
{
    public class UsersController : Controller
    {
        private readonly UsuarioServices _userServices;

        public UsersController(UsuarioServices services)
        {
            _userServices = services;
        }
        public IActionResult Index() 
        {
            var usuarios = _userServices.ObtenerProductosDisponibles();
            return View(usuarios);
        }
        public IActionResult Detalle(int id)
        {
            var usuario = _userServices.ObtenerProductoPorId(id);
            return View(usuario);
        }


    }
}
