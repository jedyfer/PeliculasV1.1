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
    public class AvalaCN
    {
        AvalaDAO objDAO = new AvalaDAO();

        public DataTable LlenarAvalas()
        {
            return objDAO.LlenarAvalas();
        }
    }
}
