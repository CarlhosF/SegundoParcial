﻿using System;
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
    public partial class PerfilEdicion : Form
    {
        Accion _AccionElegida = Accion.INSERTAR;
        Boolean _procesar = false;
        CLS.Perfil p = new CLS.Perfil();

        public Boolean Procesar
        {
            get { return _procesar; }
        }

        public enum Accion { INSERTAR, ACTUALIZAR };
        public PerfilEdicion(Accion pAccion)
        {
            InitializeComponent();
            _AccionElegida = pAccion;
        }

        public PerfilEdicion()
        {
            // TODO: Complete member initialization
        }

        public void llenarPerfil()
        {
            p.ID = txbID.Text;
            p.PERFIL = txbPerfil.Text;
            p.SERVIDOR = txbServidor.Text;
            p.DATABASE = cbbBD.Text;
            p.USUARIO = txbUsuario.Text;
            p.CONTRA = txbContra.Text;
            p.PUERTO = txbPuerto.Text;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            llenarPerfil();

            String _Cadena = @"Server=" + p.SERVIDOR +
                        ";Port=" + p.PUERTO +
                        ";Database=" + p.DATABASE +
                        ";Uid=" + p.USUARIO +
                        ";Pwd=" + p.CONTRA + ";";

            p.CADENA = _Cadena;


            try
            {
                CLS.DBConexion conexion = new CLS.DBConexion();

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
            if (MessageBox.Show("¿Esta Seguro que desea Cancelar?", "Confirmacion", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
