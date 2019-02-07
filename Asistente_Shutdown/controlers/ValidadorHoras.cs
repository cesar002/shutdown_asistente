using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Asistente_Shutdown.controlers {
    class ValidadorHoras {

        public static Boolean validarDatos(String dato) {

            if (dato.Equals("")) {
                return true;
            }

            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");

            if (Val.IsMatch(dato)) {
                return true;
            }

            return false;
        }

    }
}
