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
    public class Metalico
    {
        // INSTÂNCIA CONEXÃO SQL SERVER
         MySQL_AcessoBancoDados MySQL = new MySQL_AcessoBancoDados();

        // MÉTODOS
        #region grupo
        public CodigoCorParGrupo grupo(int PosicaoPar)
        {
            var grupo = new CodigoCorParGrupo();

            MySQL.LimparParametros();
            MySQL.AdicionarParametro("varPosicao", PosicaoPar);
            DataTable dataTable = MySQL.Consultar(CommandType.StoredProcedure, "CodigoCorParGrupo");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                grupo.Posicao = Convert.ToInt32(dataRow["Posicao"]);
                grupo.GrupoCor_A = Convert.ToString(dataRow["GrupoCor_A"]);
                grupo.GrupoCor_B = Convert.ToString(dataRow["GrupoCor_B"]);
                grupo.ParCor_A = Convert.ToString(dataRow["ParCor_A"]);
                grupo.ParCor_B = Convert.ToString(dataRow["ParCor_B"]);
                grupo.GrupoCor_Ahd = Convert.ToString(dataRow["GrupoCor_Ahd"]);
                grupo.GrupoCor_Bhd = Convert.ToString(dataRow["GrupoCor_Bhd"]);
                grupo.ParCor_Ahd = Convert.ToString(dataRow["ParCor_Ahd"]);
                grupo.ParCor_Bhd = Convert.ToString(dataRow["ParCor_Bhd"]);
            }

            return grupo;
        }
        #endregion
        #region SuperGrupo
        public CodigoCorParSuperGrupo SuperGrupo(int PosicaoPar)
        {
            var SuperGrupo = new CodigoCorParSuperGrupo();

            MySQL.LimparParametros();
            MySQL.AdicionarParametro("varPosicao", PosicaoPar);
            DataTable dataTable = MySQL.Consultar(CommandType.StoredProcedure, "CodigoCorParSuperGrupo");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                SuperGrupo.Posicao = Convert.ToInt32(dataRow["Posicao"]);
                SuperGrupo.ParCor_A = Convert.ToString(dataRow["ParCor_A"]);
                SuperGrupo.ParCor_B = Convert.ToString(dataRow["ParCor_B"]);
                SuperGrupo.SubCor_A = Convert.ToString(dataRow["SubCor_A"]);
                SuperGrupo.SubCor_B = Convert.ToString(dataRow["SubCor_B"]);
                SuperGrupo.SuperCor_A = Convert.ToString(dataRow["SuperCor_A"]);
                SuperGrupo.SuperCor_B = Convert.ToString(dataRow["SuperCor_B"]);
                SuperGrupo.ParCor_Ahd = Convert.ToString(dataRow["ParCor_Ahd"]);
                SuperGrupo.ParCor_Bhd = Convert.ToString(dataRow["ParCor_Bhd"]);
                SuperGrupo.SubCor_Ahd = Convert.ToString(dataRow["SubCor_Ahd"]);
                SuperGrupo.SubCor_Bhd = Convert.ToString(dataRow["SubCor_Bhd"]);
                SuperGrupo.SuperCor_Ahd = Convert.ToString(dataRow["SuperCor_Ahd"]);
                SuperGrupo.SuperCor_Bhd = Convert.ToString(dataRow["SuperCor_Bhd"]);
            }

            return SuperGrupo;
        }
        #endregion
    }
}
