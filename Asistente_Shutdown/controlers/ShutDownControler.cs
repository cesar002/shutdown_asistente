using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistente_Shutdown.controlers {
    class ShutDownControler {
        private int minutos = 0;

        public void setDatos(String horas, String minutos) {
            if(!horas.Equals("")) {
                if (!ValidadorHoras.validarDatos(horas) && !ValidadorHoras.validarDatos(minutos)) {
                    return;
                }

                int horas_convert = 0, minutos_convert = 0;

                Int32.TryParse(horas, out horas_convert);

                if (minutos.Equals("")) {
                    minutos_convert = 0;
                } else {
                    Int32.TryParse(minutos, out minutos_convert);
                }
                
                int horas_aux = (horas_convert * 60) * 60;
                int minutos_aux = (minutos_convert * 60) ;

                this.minutos = horas_aux + minutos_aux;

            } else {
                if (!ValidadorHoras.validarDatos(minutos)) {
                    return;
                }

                int  minutos_convert = 0;

                Int32.TryParse(minutos, out minutos_convert);

                int minutos_aux = minutos_convert * 60;

                this.minutos = minutos_aux;

            }
        }

        public void iniciar() {
            if(this.minutos == 0) {
                return;
            }

            try {
                var psi = new ProcessStartInfo("shutdown", "/s /t " + this.minutos); 
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            } catch (Exception e) {
                MessageBox.Show("error al ejecutar el shutdown", "error");
            }
            
        }

        public void cancelar() {
            try {
                var psi = new ProcessStartInfo("shutdown", "-a"); 
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            } catch (Exception e) {
                MessageBox.Show("error al cancelar el shutdown", "error");
            }
        }

    }
}
