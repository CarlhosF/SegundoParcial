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
    class Comandos
    {
        String _ARCHIVO;

        public String ARCHIVO
        {
            get { return _ARCHIVO; }
            set { _ARCHIVO = value; }
        }
        

        public void rutas_de_archivo(Perfil pPerfil, TextBox txbCarpeta, TextBox txbRuta, String FechaActual, int opcion)
        {
            char[] chartotrim = { ' ' };
            string path = @"C:\Respaldos\";
               txbCarpeta.Text = path ;
                if (opcion == 1)
                {
                    
                    txbRuta.Text = String.Format(@"{1}" + pPerfil.SERVIDOR + "{0}[" + FechaActual + "].sql{1}", new object[]{' ','"'});
                }
                else if (opcion == 2)
                {
                    
                    txbRuta.Text = String.Format(@"{1}" + pPerfil.DATABASE + "{0}[" + FechaActual + "].sql{1}", new object[]{' ', '"'});
                }
           ARCHIVO = txbRuta.Text;
        }

        public void Respaldar_Todas_BD(TextBox txbCarpeta,TextBox txbRuta, Perfil pPerfil)
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

                cmd.StandardInput.WriteLine(@"cd Dump\" );
                cmd.StandardInput.Flush();

                cmd.StandardInput.WriteLine(@"mysqldump -h"+ pPerfil.SERVIDOR +
                                            " -P"+ pPerfil.PUERTO +
                                            " -u"+ pPerfil.USUARIO +
                                            " -p"+ pPerfil.CONTRA +
                                            " --all-databases > " + txbCarpeta.Text + ARCHIVO);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();

                MessageBox.Show("Respaldo realizado con exito.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbCarpeta.Clear();
                txbRuta.Clear();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error en el resplado, intente mas tarde.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Respaldar_BD(TextBox txbCarpeta, TextBox txbRuta, Perfil pPerfil)
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

                cmd.StandardInput.WriteLine(@"mysqldump -h" + pPerfil.SERVIDOR +
                                            " -P" + pPerfil.PUERTO +
                                            " -u" + pPerfil.USUARIO +
                                            " -p" + pPerfil.CONTRA +
                                            " --databases " + pPerfil.DATABASE + " > " + txbCarpeta.Text + ARCHIVO);
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
