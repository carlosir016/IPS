using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPM_IPS.PLFLARCCAYRClassWeb
{
    public partial class Elemento
    {
        public string GetnombreTipoCalculadaValue()
        {
            return string.Format("<{0}> {1}", this.tipoDato, this.nombre);
        }

        public void SetComunidadCalculadaValue(String newValue)
        {

        }
    }
}
