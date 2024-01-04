using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;




namespace Negocios
{
     public class Usuario
    {
       
        public string ValidacionUsuario(string email, string pass)
        {
            string resultado = "";
            //WHERE NombreUsuario = '{0}' AND Contrasenia = '{1}'", user , pass
            string strSQL = string.Format("SELECT [email] , [pass] FROM Usuarios ");

            SQLConec obj = new SQLConec();
            SqlConnection conec = obj.ConexionDB();


            conec.Open();

            SqlCommand cmd = new SqlCommand(strSQL, conec);

            SqlDataReader dataread = null;

            dataread = cmd.ExecuteReader();

            try
            {
                while (dataread.Read())
                {
                    string Email = Convert.ToString(dataread.GetString(0));
                    string contra = Convert.ToString(dataread.GetString(1));

                    if (email == Email && pass == contra)
                    {
                        resultado = "usuario existe";
                        break;
                    }
                    else if(email == Email)
                    {
                        resultado = "email ocupado"; 
                    }
                    else
                    {
                        resultado = "usuario no existe"; 

                    }
                }//end while

                dataread.Close();

                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "error";
            }
            finally
            {
                conec.Close();
            }

        }
        public string AgregarUsuario(string email, string user, string direccion, string telefono, string pass)
        {
            string result = "";

            //////////////////////////////////////////////////////////////////
            //PRIMERO VALIDA SI EL USUARIO YA ESTABA REGISTRADO        ///////
            string resultadoValidacion = ValidacionUsuario(email, pass);          ///////
            //////////////////////////////////////////////////////////////////
            if (resultadoValidacion.Equals("usuario existe") || resultadoValidacion.Equals("email ocupado"))
            {
                result = "ya tiene cuenta"; 

            }
            else
            {
                //el usuario no existe 

                SQLConec obj = new SQLConec();
                SqlConnection conec = obj.ConexionDB();
                conec.Open();


                try
                {
                    string insert = "INSERT INTO Usuarios (email, username, direccion, telefono, pass) " +
                        "            VALUES (@email, @username, @direccion , @telefono , @pass)";

                    using (SqlCommand command = new SqlCommand(insert, conec))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@username", user);
                        command.Parameters.AddWithValue("@direccion", direccion);
                        command.Parameters.AddWithValue("@telefono", telefono);
                        command.Parameters.AddWithValue("@pass", pass);

                        command.ExecuteNonQuery();

                        result = "valido";
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return "error";
                }
                finally
                {
                    conec.Close();
                }

            }
             return result;
        }

        public string ObtenerID_User(string email)
        {
            string userID = null;
            string strSQL = "SELECT userId FROM Usuarios WHERE email = @email";

            SQLConec obj = new SQLConec();
            SqlConnection conec = obj.ConexionDB();

            try
            {
                conec.Open();

                SqlCommand cmd = new SqlCommand(strSQL, conec);
                cmd.Parameters.AddWithValue("@email", email);

                SqlDataReader dataread = cmd.ExecuteReader();

                if (dataread.Read())
                {
                    userID = dataread["userId"].ToString();
                }

                dataread.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conec.Close();
            }

            return userID;
        }









    }//end usuario


}//end namespace
