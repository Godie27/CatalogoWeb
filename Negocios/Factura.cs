using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Negocios
{
    public class Factura
    { 
        public bool AgregarCompra(Compra compra)
        {
            SQLConec obj = new SQLConec();
            SqlConnection conec = obj.ConexionDB();
            bool valido = false; 

            try
            {
                conec.Open();

                //Realiza un insert y luego un select para obtener el ultimo elemento recien ingresado

                string insertCompra = "INSERT INTO Ventas (userID, fecha_venta, total) " +
                    "                  VALUES (@userID, @fecha_venta, @total); " +
                    "                  SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(insertCompra, conec))
                {
                    command.Parameters.AddWithValue("@userID", Convert.ToInt32(compra.userID));
                    command.Parameters.AddWithValue("@fecha_venta", DateTime.Now);
                    command.Parameters.AddWithValue("@total", Convert.ToDouble(compra.total));


                    //obtiene el id de la venta que se inserto arriba 
                    int ventaID = Convert.ToInt32(command.ExecuteScalar());

                    
                    string insertInfoCompra = "INSERT INTO Informacion_Compra (ventaID, nombre_articulo, cantidad , subtotal) " +
                        "                      VALUES (@ventaID, @nombre_articulo, @cantidad , @subtotal);";
                    foreach (var articulo in compra.articulos)
                    {
                        using (SqlCommand cmd = new SqlCommand(insertInfoCompra, conec))
                        {
                            cmd.Parameters.AddWithValue("@ventaID", ventaID);
                            cmd.Parameters.AddWithValue("@nombre_articulo", articulo.nombre_articulo);
                            cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(articulo.cantidad));
                            cmd.Parameters.AddWithValue("@subtotal", Convert.ToDouble(articulo.subtotal));

                            cmd.ExecuteNonQuery();
                        }
                    }//end foreach
                }//end using

                valido = true;

            }
            catch (Exception)
            {

                throw;
            }

            return valido;

        } //end metodo agregarcompra

    }//end class 
} //end namespace
