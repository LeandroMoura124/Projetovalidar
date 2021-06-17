
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projetovalidar.Models;

namespace Projetovalidar.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            var usuario = new Usuario(); //criei obejto 
            return View(usuario); //retornei para view os dados
        }
        [HttpPost]
        public ActionResult Index(Usuario usuario)
        {
            if (ModelState.IsValid) // validando o estado , ou seja, verificando a requisicao
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {

                "Leandro",
                "TravisScott"
            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()),
                                        JsonRequestBehavior.AllowGet);
        }
    }
}