using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using BLL;

namespace WEB.Metodos
{
    public class Erro
    {
        #region enviarErro
        public bool enviarErro(string origem, string erroGerado)
        {
            try
            {              
                var bll = new BLL.Sistema();
                bll.sistemaErroSalvar(origem, erroGerado);
                bool retono = true;
                return retono;
            }
            catch (Exception)
            {
                bool retono = false;
                return retono;
            }
        }
        #endregion
    }
}