using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicial.CLS
{
    public class Conexion
    {
        String _ID;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        String _PERFIL;

        public String PERFIL
        {
            get { return _PERFIL; }
            set { _PERFIL = value; }
        }
        String _SERVIDOR;

        public String SERVIDOR
        {
            get { return _SERVIDOR; }
            set { _SERVIDOR = value; }
        }
        String _PUERTO;

        public String PUERTO
        {
            get { return _PUERTO; }
            set { _PUERTO = value; }
        }
        String _USUARIO;

        public String USUARIO
        {
            get { return _USUARIO; }
            set { _USUARIO = value; }
        }
        String _CONTRA;

        public String CONTRA
        {
            get { return _CONTRA; }
            set { _CONTRA = value; }
        }
        String _DATABASE;

        public String DATABASE
        {
            get { return _DATABASE; }
            set { _DATABASE = value; }
        }

        String _CADENA;

        public String CADENA
        {
            get { return _CADENA; }
            set { _CADENA = value; }
        }
    }
}
