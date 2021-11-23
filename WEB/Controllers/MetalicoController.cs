using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;
using WEB;

namespace WEB.Controllers
{
    public class MetalicoController : Controller
    {
        #region Cores
        public ActionResult Cores()
        {
            try
            {
                // INSTÂNCIA MODELO
                var codigoCorEntrada = new DTO.CodigoCorEntrada();
                return View("Cores", codigoCorEntrada);
            }
            catch (Exception exception)
            {
                // SALVAR ERRO
                var metodoErro = new WEB.Metodos.Erro();
                bool envio = metodoErro.enviarErro("Metalico/Cores", exception.ToString());
                return PartialView("~/Views/Home/_Erro.cshtml");
            }
        }
        #endregion
        #region CoresInicio
        public PartialViewResult CoresInicio()
        {
            try
            {
                // INSTÂNCIA MODELO
                var codigoCorEntrada = new DTO.CodigoCorEntrada();
                ViewBag.ScriptValidacao = "SIM";
                return PartialView("~/Views/Metalico/_Inicio.cshtml", codigoCorEntrada);
            }
            catch (Exception exception)
            {
                // SALVAR ERRO
                var metodoErro = new WEB.Metodos.Erro();
                bool envio = metodoErro.enviarErro("Metalico/CoresInicio", exception.ToString());
                return PartialView("~/Views/Metalico/_Erro.cshtml");
            }
        }
        #endregion
        #region PostCores
        [HttpPost]
        public PartialViewResult PostCores(CodigoCorEntrada codigoCorEntrada)
        {
            try
            {
                // OBTEM POSIÇÃO DO PAR NO CABO
                int posicaoPar = codigoCorEntrada.ParDesejado - codigoCorEntrada.ParInicial + 1;

                // POSIIÇÃO NEGATIVA
                if (posicaoPar <= 0)
                {
                    ViewBag.ParInicio = codigoCorEntrada.ParInicial;
                    ViewBag.ParDesejado = codigoCorEntrada.ParDesejado;
                    ViewBag.Posicaonegativa = "PAR DEVE SER IGUAL OU MAIOR QUE " + codigoCorEntrada.ParInicial.ToString();
                    return PartialView("~/Views/Metalico/_Inicio.cshtml", codigoCorEntrada);
                }

                // POSIÇÃO MENOR QUE 300
                if (posicaoPar > 0 && posicaoPar <= 300)
                {
                    var bll = new BLL.Metalico();
                    var cores = new DTO.CodigoCorParGrupo();
                    cores = bll.grupo(posicaoPar);
                    ViewBag.ParDesjado = codigoCorEntrada.ParDesejado;
                    return PartialView("~/Views/Metalico/_ResultadoGrupo.cshtml", cores);
                }

                // POSIÇÃO MAIOR QUE 300
                else
                {
                    var bll = new BLL.Metalico();
                    var cores = new DTO.CodigoCorParSuperGrupo();
                    cores = bll.SuperGrupo(posicaoPar);
                    ViewBag.ParDesjado = codigoCorEntrada.ParDesejado;
                    return PartialView("~/Views/Metalico/_ResultadoSuperGrupo.cshtml", cores);
                }
            }
            catch (Exception exception)
            {
                // SALVAR ERRO
                var metodoErro = new WEB.Metodos.Erro();
                bool envio = metodoErro.enviarErro("Metalico/PostCores", exception.ToString());
                return PartialView("~/Views/Metalico/_Erro.cshtml");
            }
        }
        #endregion
        #region SaibaMais
        public PartialViewResult SaibaMais()
        {
            return PartialView("~/Views/Metalico/_SaibaMais.cshtml");
        }
        #endregion
    }
}