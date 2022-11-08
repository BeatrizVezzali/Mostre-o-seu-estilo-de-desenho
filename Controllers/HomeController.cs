using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using PI_MVC.Models;

namespace PI_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Galeria()
        {
            return View();
        }

        public IActionResult Portfólio()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Fale()
        {
            return View();
        }

        public IActionResult Início_Site()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        

         public IActionResult Cadastro(Cadastro C)
        { 

		   try
		   {
           CadastroRepository cR = new CadastroRepository();
            cR.Inserir(C);
		   }
           catch(Exception e)
		   {
               _logger.LogError("Erro de cadastro" + e.Message);
		   }

            return View("Sucesso");
        }

        [HttpPost]

        public IActionResult Fale(Fale F)
        {
			try
			{
            FaleRepository fR = new FaleRepository();
            fR.Inserir(F);
			}
			catch(Exception e)
			{
				_logger.LogError("Falha no envio" + e.Message);
			}

            return View();
        }

        [HttpPost]
        
         public IActionResult Login(Login L)
        {
			
           LoginRepository lR = new LoginRepository();
           Login usuárioLogado = lR.validarLogin(L);

           if(usuárioLogado == null)
                {
					_logger.LogError("Erro de login");
                return View();
                }

                else 
               {      
                HttpContext.Session.SetInt32("idUsuário", usuárioLogado.iDUsuario); 
                
                return RedirectToAction("Index");
              }
        }
              public IActionResult Logout()
              {
                HttpContext.Session.Clear();

                return RedirectToAction("Login");
              }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
