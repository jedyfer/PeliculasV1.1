using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocios
{
    public class EmpleadoCN
    {
        EmpleadoDAO objDAO = new EmpleadoDAO();

        public DataTable ListaEmpleado()
        {
            return objDAO.ListaEmpleado();
        }

        public void NuevoEmpleado(EmpleadoCE emp)
        {
            objDAO.NuevoEmpleado(emp);
        }
    }
}
