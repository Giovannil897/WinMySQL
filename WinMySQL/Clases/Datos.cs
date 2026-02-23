using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WinMySQL.Clases
{
    internal class Datos
    {
        String cadenaConexion = "server=Localhost;user=Luis;pwd=JoseLuis";
        MySqlConnection conexion;
        private void conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString);
            }
        }
        private void desconectar()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString);
            }
        }
    }
}
