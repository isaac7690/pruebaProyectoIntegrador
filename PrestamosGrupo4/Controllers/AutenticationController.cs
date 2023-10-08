using Microsoft.AspNetCore.Mvc;
using PrestamosGrupo4.Models.Entidades;
using PrestamosGrupo4.Models.Interfaces;
using PrestamosGrupo4.Models.Repositorios;

namespace PrestamosGrupo4.Controllers
{
    public class AutenticationController : Controller
    {
        private readonly IConfiguration _configuration;
        private IUsuario user;

        public AutenticationController(IConfiguration iconfig)
        {
            _configuration = iconfig;
            user = new UsuarioRepositorio();
        }

        public IActionResult register()
        {
            return View(new UsuarioModel());
        }


    }
}
