using Inicial.GUI;
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
    public partial class Principal : Form
    {
        DataTable _Datos = new DataTable();
        CLS.Conexion p = new CLS.Conexion();

        private void GuardarLista()
        {
            _Datos.TableName = "Perfiles";
            _Datos.WriteXml("Perfiles.xml");
        }

        private void LeerLista()
        {
            _Datos.TableName = "Perfiles";
            _Datos.ReadXml("Perfiles.xml");
        }

        private void Configurar()
        {
            _Datos.Columns.Add("cID");
            _Datos.Columns.Add("cPerfil");
            _Datos.Columns.Add("cServidor");
            _Datos.Columns.Add("cBaseDatos");
            _Datos.Columns.Add("cUsuario");
            _Datos.Columns.Add("cContra");
            _Datos.Columns.Add("cPuerto");

            dtgDatos.AutoGenerateColumns = false;
            dtgDatos.DataSource = _Datos;
        }

        private void ContarRegistros()
        {
            
        }

        private void generarPath()
        {
            string value;

            value = Environment.GetEnvironmentVariable("MYSQL");

            if (value == null)
            {
                Environment.SetEnvironmentVariable("MYSQL", @"C:\Program Files\MySQL\MySQL Server 5.7\bin");
                value = Environment.GetEnvironmentVariable("MYSQL");
            }
        }

        private void Agregar(PerfilEdicion f)
        {
         
            DataRow nFila = _Datos.NewRow();

            
            nFila["cID"] = f.txbID.Text;
            nFila["cPerfil"] = f.txbPerfil.Text;
            nFila["cServidor"] = f.txbServidor.Text;
            nFila["cBaseDatos"] = f.cbbBD.Text;
            nFila["cUsuario"] = f.txbUsuario.Text;
            nFila["cContra"] = f.txbContra.Text;
            nFila["cPuerto"] = f.txbPuerto.Text;


            _Datos.Rows.Add(nFila);
            GuardarLista();
            ContarRegistros();

            MessageBox.Show("Perfil Agregado Correctamente", "Confirmacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Editar()
        {
            try
            {
                PerfilEdicion f = new PerfilEdicion(PerfilEdicion.Accion.ACTUALIZAR);

                f.txbID.Text = dtgDatos.CurrentRow.Cells["ID"].Value.ToString();
                f.txbPerfil.Text = dtgDatos.CurrentRow.Cells["Perfil"].Value.ToString();
                f.txbServidor.Text = dtgDatos.CurrentRow.Cells["Servidor"].Value.ToString();
                f.cbbBD.Text = dtgDatos.CurrentRow.Cells["BaseDatos"].Value.ToString();
                f.txbUsuario.Text = dtgDatos.CurrentRow.Cells["Usuario"].Value.ToString();
                f.txbContra.Text = dtgDatos.CurrentRow.Cells["Contra"].Value.ToString();
                f.txbPuerto.Text = dtgDatos.CurrentRow.Cells["Puerto"].Value.ToString();

                f.txbID.ReadOnly = true;
                f.txbID.Enabled = false;

                f.ShowDialog();

                if (f.Procesar)
                {

                    dtgDatos.CurrentRow.Cells["ID"].Value = f.txbID.Text;
                    dtgDatos.CurrentRow.Cells["Perfil"].Value = f.txbPerfil.Text;
                    dtgDatos.CurrentRow.Cells["Servidor"].Value = f.txbServidor.Text;
                    dtgDatos.CurrentRow.Cells["BaseDatos"].Value = f.cbbBD.Text;
                    dtgDatos.CurrentRow.Cells["Usuario"].Value = f.txbUsuario.Text;
                    dtgDatos.CurrentRow.Cells["Contra"].Value = f.txbContra.Text;
                    dtgDatos.CurrentRow.Cells["Puerto"].Value = f.txbPuerto.Text;

                    GuardarLista();
                    MessageBox.Show("Perfil Editado Correctamente", "Confirmacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch 
            {
                
            }
            
        }

        public Principal()
        {
            InitializeComponent();
            
            Configurar();
            LeerLista();
            ContarRegistros();
            generarPath();
            this.dtgDatos.Sort(this.dtgDatos.Columns["ID"],ListSortDirection.Ascending);
        }


        private void btnPerfil_Click(object sender, EventArgs e)
        {
            try
            {

                PerfilEdicion f = new PerfilEdicion(PerfilEdicion.Accion.INSERTAR);
               f.ShowDialog();

                if (f.Procesar)
                {
                    Agregar(f);
                }
            }
            catch
            {
                
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea EDITAR el Perfil seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Editar();
            }
        }

        private CLS.Conexion llenarPerfil()
        {
            p.ID = dtgDatos.CurrentRow.Cells["ID"].Value.ToString();
            p.PERFIL = dtgDatos.CurrentRow.Cells["Perfil"].Value.ToString();
            p.SERVIDOR = dtgDatos.CurrentRow.Cells["Servidor"].Value.ToString();
            p.DATABASE = dtgDatos.CurrentRow.Cells["BaseDatos"].Value.ToString();
            p.USUARIO = dtgDatos.CurrentRow.Cells["Usuario"].Value.ToString();
            p.CONTRA = dtgDatos.CurrentRow.Cells["Contra"].Value.ToString();
            p.PUERTO = dtgDatos.CurrentRow.Cells["Puerto"].Value.ToString();

            return p;
        } 


        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ELIMINAR el Perfil seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtgDatos.Rows.RemoveAt(dtgDatos.CurrentRow.Index);
                GuardarLista();
                ContarRegistros();
                MessageBox.Show("Perfil Eliminado Correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void todasLasBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GenerarRespaldo f = new GenerarRespaldo(llenarPerfil(),1);
            f.ShowDialog();


        }

        private void lblBDSeleccion_Click(object sender, EventArgs e)
        {

            GenerarRespaldo f = new GenerarRespaldo(llenarPerfil(), 2);

            f.ShowDialog();
        }

        private void lblRecovery_Click(object sender, EventArgs e)
        {
            RecoveryBD f = new RecoveryBD(llenarPerfil());
            f.ShowDialog();
        }

        private void btn_Exprotar_Click(object sender, EventArgs e)
        {

            GenerarRespaldo f = new GenerarRespaldo(llenarPerfil(), 2);

            f.ShowDialog();
        }

        private void btn_Importar_Click(object sender, EventArgs e)
        {
            RecoveryBD f = new RecoveryBD(llenarPerfil());
            f.ShowDialog();
        }

        private void btn_Exprotar_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Exp_Click(object sender, EventArgs e)
        {
            GenerarRespaldo f = new GenerarRespaldo(llenarPerfil(), 2);

            f.ShowDialog();
        }

        private void btn_Imp_Click(object sender, EventArgs e)
        {
            RecoveryBD f = new RecoveryBD(llenarPerfil());
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
