using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicial.GUI
{
    public partial class RecoveryBD : Form
    {

        CLS.Perfil _perfil;

        public CLS.Perfil Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }


        public RecoveryBD(CLS.Perfil perfil)
        {
            InitializeComponent();
            _perfil = perfil;

        }

        private void recuperarBD(CLS.Perfil p)
        {
            string ruta = "";
            CLS.DBConexion Conexion = new CLS.DBConexion();
            Process cmd = new Process();

            try
            {
                OpenFileDialog seleccionar = new OpenFileDialog();
                seleccionar.Filter = "Archivos SQL (*.sql) | *.sql";
                seleccionar.Title = "Selecciona Respaldo";
                seleccionar.InitialDirectory = @"C:\Respaldos";

                if (seleccionar.ShowDialog() == DialogResult.OK)
                {
                    string path = Directory.GetCurrentDirectory();
                    ruta = seleccionar.FileName;
                    txbArchivo.Text = String.Format("{0}"+ruta+"{0}",'"');

                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();

                    cmd.StandardInput.WriteLine(@"mysql " + "-p" + p.CONTRA +
                                                " -u " + p.USUARIO +
                                                " "+ p.DATABASE +" < " + txbArchivo.Text);
                    progreso();
                  
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();


                    MessageBox.Show("Recovery Realizado con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("No se ha podido realizar el recovery, intentelo mas tarde.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void progreso()
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que desea Cancelar?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            recuperarBD(Perfil);
        }

        private void pgbProgreso_Click(object sender, EventArgs e)
        {

        }

        private void RecoveryBD_Load(object sender, EventArgs e)
        {

        }
    }
}
