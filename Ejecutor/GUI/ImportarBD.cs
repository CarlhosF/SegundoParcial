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
    public partial class ImportarBD : Form
    {

        CLS.Conexion _perfil;

        public CLS.Conexion Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }


        public ImportarBD(CLS.Conexion perfil)
        {
            InitializeComponent();
            _perfil = perfil;

        }

        private void recuperarBD(CLS.Conexion p)
        {
            string ruta = "";
            CLS.BDConector Conexion = new CLS.BDConector();
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
                                                " "+ p._DATABASE +" < " + txbArchivo.Text);
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
