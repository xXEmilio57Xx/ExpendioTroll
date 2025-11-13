using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Expendio.Clases
{
   public class ConexionLogin
   {

      SqlDataReader reader;
      SqlCommand command;
      SqlConnection conexion = new SqlConnection("server = localhost\\SQLEXPRESS; database = EXPENDIO; integrated security = true;");

      string usuario = "";
      string contraseña = "";
      
      public ConexionLogin(string usuario, string contraseña)
      {
         this.usuario = usuario;
         this.contraseña = contraseña;
      }


      public int Login()
      {
         if (conexion.State == System.Data.ConnectionState.Open)
            conexion.Close();

         conexion.Open();

         string query = $"SELECT EMP_TIPO FROM EMPLEADO WHERE EMP_NOMBRE = '{usuario}' AND EMP_CONTRASEÑA = '{contraseña}'";
         command = new SqlCommand(query, conexion);

         reader = command.ExecuteReader();

         if (reader.Read())
            return reader.GetInt32(0);
         else
            return 0;
      }

   }
}
