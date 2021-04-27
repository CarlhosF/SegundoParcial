using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicial.CLS
{
    public class DBConexion
    {

         static GUI.PerfilEdicion f = new GUI.PerfilEdicion();


        protected MySqlConnection _CONEXION;

        

        public Boolean Conectar(String _Cadena)
        {
            Boolean _Conectado = false;
            _CONEXION = new MySqlConnection(_Cadena);
            try
            {
                _CONEXION.Open();
                _Conectado = true;
            }
            catch
            {
                _Conectado = false;
            }
            return _Conectado;
        }

        public void Desconectar()
        {
            try
            {
                if (_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch
            {

            }
        }
    }
}
