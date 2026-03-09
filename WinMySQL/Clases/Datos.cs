using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySqlConnector;

namespace WinMySQL.Clases
{
    internal class Datos
    {
        String cadenaConexion = "server=Localhost;user=Luis;pwd=JoseLuis;Database=escolar";
        MySqlConnection conexion;
        private void conectar()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
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
        public DataSet ejecutar(String comando)
        {
            try
            {
                conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public bool ejecutarcomando(String comando)
        {
            try
            {
                conectar();
                MySqlCommand cmd = new MySqlCommand(comando,conexion);
                cmd.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
