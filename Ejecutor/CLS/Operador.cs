using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Inicial.CLS
{
    class OPerador
    {
        String _ARCHIVO;

        public String ARCHIVO
        {
            get { return _ARCHIVO; }
            set { _ARCHIVO = value; }
        }
        

        public void Enrutar(Conexion Conexion, TextBox txbCarpeta, TextBox txbRuta, String FechaActual, int opcion)
        {
            char[] chartotrim = { ' ' };
            string path = @"C:\BDRespaldos\";
               txbCarpeta.Text = path ;
                if (opcion == 1)
                {
                    
                    txbRuta.Text = String.Format(@"{1}" + Conexion.SERVIDOR + "{0}[" + FechaActual + "].sql{1}", new object[]{' ','"'});
                }
                else if (opcion == 2)
                {
                    
                    txbRuta.Text = String.Format(@"{1}" + Conexion.DATABASE + "{0}[" + FechaActual + "].sql{1}", new object[]{' ', '"'});
                }
           ARCHIVO = txbRuta.Text;
        }

       

        public void Respaldar(TextBox txbCarpeta, TextBox txbRuta, Conexion Conexion)
        {
            try
            {
                Process cmd = new Process();
                string path = Directory.GetCurrentDirectory();

                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine(@"cd C:\");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine(@"MKDIR Respaldos");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine(@"cd " + path);
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine(@"cd..");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine(@"cd Dump\");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine(@"mysqldump -h" + Conexion.SERVIDOR +" -P" + Conexion.PUERTO +" -u" + Conexion.USUARIO +" -p" + Conexion.CONTRA +" --databases " + Conexion.DATABASE + " > " + txbCarpeta.Text + ARCHIVO);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();

                MessageBox.Show("Respaldo realizado con exito.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error en el resplado, intente mas tarde.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
