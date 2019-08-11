using Dapper;
using IInFormation.DAL;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace InFormation.DAL
{
    public class Menu_DAL: IMenu_DAL
    {
        private readonly IDbConnection _db;

        public Menu_DAL(IOptions<ReadConfig> connectionStrings)
        {
            _db = new MySqlConnection(connectionStrings.Value.ConnectionString);
        }

        public void Dispose()
        {
            _db.Close();
        }


        async Task<IEnumerable<ENT.Menu>> IMenu_DAL.getMenu()
        {
            IEnumerable<ENT.Menu> lista = new List<ENT.Menu>();


            //if (string.IsNullOrEmpty(nome))
            lista = await _db.QueryAsync<ENT.Menu>("sp_getMenu", commandType: CommandType.StoredProcedure);


            return lista;
        }
    }
}
