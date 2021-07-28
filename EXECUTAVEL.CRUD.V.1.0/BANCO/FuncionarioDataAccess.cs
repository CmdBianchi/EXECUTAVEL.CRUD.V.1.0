using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
namespace EXECUTAVEL.CRUD.V._1._0.BANCO {

    // --- > Classe reponsavel por fazer a consulta
    class FuncionarioDataAccess {
        public static DataTable PegarFUncionario() {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=C:\Users\marcu\source\repos\EXECUTAVEL.CRUD.V.1.0\EXECUTAVEL.CRUD.V.1.0\BANCO\Banco.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Funcionario", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }
    }
}
