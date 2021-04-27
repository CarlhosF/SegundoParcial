using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicial.GUI
{
    public partial class ConexionlEdicion : Form
    {
        Accion _AccionElegida = Accion.INSERTAR;
        Boolean _procesar = false;
        CLS.Conexion p = new CLS.Conexion();

        public Boolean Procesar
        {
            get { return _procesar; }
        }

        public enum Accion { INSERTAR, ACTUALIZAR };
        public ConexionlEdicion(Accion pAccion)
        {
            InitializeComponent();
            _AccionElegida = pAccion;
        }

        public ConexionlEdicion()
        {
            
        }

        public void llenarPerfil()
        {
            p.ID = txbID.Text;
            p.PERFIL = txbPerfil.Text;
            
            p._DATABASE = cbbBD.Text;
            p.USUARIO = txbUsuario.Text;
            p.CONTRA = txbContra.Text;
            
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            llenarPerfil();

            String _Cadena = @"Server=" + p.SERVIDOR +";Port=" + p._PUERTO +";Database=" + p._DATABASE +";Uid=" + p.USUARIO +";Pwd=" + p.CONTRA + ";";

            p.CADENA = _Cadena;


            try
            {
                CLS.BDConector conexion = new CLS.BDConector();

                if (conexion.Conectar(p.CADENA))
                {
                    MessageBox.Show("Conexion a base de datos con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _procesar = true;
                    conexion.Desconectar();
                    Close();
                }
                else
                {
                    _procesar = false;
                    conexion.Desconectar();
                    MessageBox.Show("Intento de Conexion con la Base de datos fallida, verifique sus datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch
            {
                MessageBox.Show("No es posible conectarse al servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
                Close();
            
        }
    }
}
