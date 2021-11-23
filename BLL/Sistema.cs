using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public  class Sistema
    {
        // INSTÂNCIA CONEXÃO SQL SERVER
        MySQL_AcessoBancoDados MySQL = new MySQL_AcessoBancoDados();

        // MÉTODOS
        #region sistemaEmailCredenciais
        public SistemaEmailCredenciais sistemaEmailCredenciais(string perfil)
        {
            var sistemaEmailCredenciais = new SistemaEmailCredenciais();

            MySQL.LimparParametros();
            MySQL.AdicionarParametro("varPerfil", perfil);
            DataTable dataTable = MySQL.Consultar(CommandType.StoredProcedure, "SistemaEmailCredenciais");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                sistemaEmailCredenciais.Perfil = Convert.ToString(dataRow["Perfil"]);
                sistemaEmailCredenciais.Email = Convert.ToString(dataRow["Email"]);
                sistemaEmailCredenciais.Senha = Convert.ToString(dataRow["Senha"]);
                sistemaEmailCredenciais.Codigo = Convert.ToString(dataRow["Codigo"]);
            }

            return sistemaEmailCredenciais;
        }
        #endregion
        #region sistemaErroSalvar
        public void sistemaErroSalvar(string origem, string erroGerado)
        {
            MySQL.LimparParametros();
            MySQL.AdicionarParametro("varOrigem", origem);
            MySQL.AdicionarParametro("varErroGerado", erroGerado);
            MySQL.Consultar(CommandType.StoredProcedure, "SistemaErroSalvar");
        }
        #endregion
    }
}
