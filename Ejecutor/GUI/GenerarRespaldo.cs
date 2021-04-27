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
    public partial class GenerarRespaldo : Form
    {
        char[] chartotrim = { ' ' };

        CLS.Comandos cmd = new CLS.Comandos();
        string fecha = String.Format(DateTime.Now.ToString("yyyy-MM-dd{0}HH{0}mm"),' ');
        CLS.Perfil _perfil;

        public CLS.Perfil Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        int _OPCION;

        public int OPCION
        {
            get { return _OPCION; }
            set { _OPCION = value; }
        }


        public GenerarRespaldo(CLS.Perfil Perfil,int opcion)
        {
            InitializeComponent();
            _perfil = Perfil;
            _OPCION = opcion;
            cmd.rutas_de_archivo(_perfil, txbCarpeta, txbRuta, fecha, _OPCION);
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que desea Cancelar el Respaldo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            if (_OPCION == 1)
            {
                cmd.Respaldar_Todas_BD(txbCarpeta, txbRuta, _perfil);
                Close();
            }
            else if (_OPCION == 2)
            {
                cmd.Respaldar_BD(txbCarpeta, txbRuta, _perfil);
                Close();
            }
        }

        private void GenerarRespaldo_Load(object sender, EventArgs e)
        {
            lblNota.Text = "Nota: Se creará una carpeta con el nombre de 'Resplados'\nen el disco " + @"'C:\'" + " para almacenar cada archivo generado";
        }

        
    }
}
