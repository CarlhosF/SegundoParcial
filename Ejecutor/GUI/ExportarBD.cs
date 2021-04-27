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
    public partial class ExportarBD : Form
    {
        char[] chartotrim = { ' ' };

        CLS.OPerador cmd = new CLS.OPerador();
        string fecha = String.Format(DateTime.Now.ToString("yyyy-MM-dd{0}HH{0}mm"),' ');
        CLS.Conexion _perfil;

        public CLS.Conexion Perfil
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


        public ExportarBD(CLS.Conexion Perfil,int opcion)
        {
            InitializeComponent();
            _perfil = Perfil;
            _OPCION = opcion;
            cmd.Enrutar(_perfil, txbCarpeta, txbRuta, fecha, _OPCION);
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
                
                Close();
            }
            else if (_OPCION == 2)
            {
                cmd.Respaldar(txbCarpeta, txbRuta, _perfil);
                Close();
            }
        }

        private void GenerarRespaldo_Load(object sender, EventArgs e)
        {
            lblNota.Text = "Nota: Se creará una carpeta con el nombre de 'Resplados'\nen el disco " + @"'C:\'" + " para almacenar cada archivo generado";
        }

        
    }
}
