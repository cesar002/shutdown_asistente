using Asistente_Shutdown.controlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistente_Shutdown
{
    public partial class VentanaMain : Form
    {
        private ShutDownControler shutDown = new ShutDownControler();

        public VentanaMain()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnIniciar_Click(object sender, EventArgs e) {
           this.shutDown.setDatos(this.txtHoras.Text, this.txtMinutos.Text);
            this.shutDown.iniciar();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.shutDown.cancelar();
        }
    }
}
