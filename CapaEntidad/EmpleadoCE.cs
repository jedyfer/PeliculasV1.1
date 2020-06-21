using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EmpleadoCE
    {
		public string empCodigo { get; set; }
		public string emp_Apellidos { get; set; }
		public string emp_Nombres { get; set; }
		public object empDireccion { get; set; }
		public string emp_lugar { get; set; }
		public object empTelefono { get; set; }
		public object empE_mail { get; set; }
		public DateTime emp_feching { get; set; }
		public DateTime empFechNac { get; set; }
		public int empSueldo { get; set; }
	}
}
