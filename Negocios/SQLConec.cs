using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class SQLConec
    {
        public SqlConnection ConexionDB()
        {
            SqlConnection connection;

            try
            {
                // Cadena de conexión a la base de datos
                string connectionString = "Data Source=DESKTOP-021GUL0;Initial Catalog=Proyecto5;" +
                                          "User ID=sa;Password=sqlserver";

                // Crea una conexión a la base de datos
                connection = new SqlConnection(connectionString);

            }
            catch (Exception)
            {
                throw;
            }

            return connection;

        }

    }
}
