using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        #region Index
        public ActionResult Index()
        {
            return View("Index");
        }
        #endregion
        #region Mensagem
        public PartialViewResult Mensagem()
        {
            try
            {
                // INSTÂNCIA MODELO
                var homeContato = new DTO.HomeContato();
                return PartialView("~/Views/Home/_Contato.cshtml", homeContato);
            }
            catch (Exception exception)
            {
                // SALVAR ERRO
                var metodoErro = new WEB.Metodos.Erro();
                bool envio = metodoErro.enviarErro("Home/Mensagem", exception.ToString());
                return PartialView("~/Views/Home/_Erro.cshtml");
            }
        }
        #endregion
        #region PostMensagem
        [HttpPost]
        public PartialViewResult PostMensagem(DTO.HomeContato homeContato)
        {
            try
            {
                // INSTÂNCIAS
                var metodoEmail = new WEB.Metodos.Email();
                var metodoErro = new WEB.Metodos.Erro();
                bool envioEmail = metodoEmail.EmailContato(homeContato);

                // SE HOUVER ERRO AO ENVIAR E-MAIL
                if (envioEmail == false)
                {
                    // SALVAR ERRO
                    bool envio = metodoErro.enviarErro("Home/PostMensagem", "Erro ao enviar o E-mail");
                }

                ViewBag.Retorno = envioEmail;
                ViewBag.Nome = homeContato.Nome;
                return PartialView("~/Views/Home/_ContatoRetorno.cshtml");
            }
            catch (Exception exception)
            {
                // SALVAR ERRO
                var metodoErro = new WEB.Metodos.Erro();
                bool envio = metodoErro.enviarErro("Home/PostMensagem", exception.ToString());
                return PartialView("~/Views/Home/_Erro.cshtml");
            }
        }
        #endregion
    }
}