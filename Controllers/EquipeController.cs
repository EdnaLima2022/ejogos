using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {
  
        //ActionResult representam os varios codigos HTTP, 
        //Codigos HTTP: https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status

        Equipe equipeModel = new Equipe();
        public IActionResult Index()
        {
            //ViewBag = Reserva de espaço para armazenar informações para 
            //recuperar na VIEW
            //Tem a função de carregar as informações do Controleer para a VIEW

            ViewBag.Equipes = equipeModel.LerEquipes();
            
            return View();
        }

        
    }
}
