using IInFormation.DAL;
using InFormation.DAL.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using InFormation.ENT;
using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;

namespace InFormation.DAL
{
    public class Menu : IMenu
    {
        private readonly IDbConnection _db;

        public Menu(IOptions<ReadConfig> connectionStrings)
        {
            _db = new MySqlConnection(connectionStrings.Value.ConnectionString);
        }

        public void Dispose()
        {
            _db.Close();
        }

        //IOptions<ReadConfig> _ConnectionString;
        //public Menu(IOptions<ReadConfig> ConnectionString)
        //{
        //    _ConnectionString = ConnectionString;
        //}

        public string getMenu()
        {
            //string sql = "SELECT tx_titulo,tx_lugar FROM auditoria.tbl_actareunion;";

            //using (SqlConnection con = new SqlConnection(_ConnectionString.Value.ConnectionString))
            //{
            //    var orderDetails = con.Query<Demo>(sql);

            //    //FiddleHelper.WriteTable(orderDetails);
            //}

            List<Demo> lista = new List<Demo>();
            string nome = "Juiz de Fora";

            //if (string.IsNullOrEmpty(nome))
                lista = _db.Query<Demo>("SELECT tx_titulo,tx_lugar FROM auditoria.tbl_actareunion;").ToList();

            nome = nome.Trim();

            return "";
        }
    }
}
