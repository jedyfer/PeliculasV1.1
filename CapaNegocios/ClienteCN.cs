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
    public class ClienteCN
    {
        ClienteDAO objDAO = new ClienteDAO();

        public DataTable ListaCliente()
        {
            return objDAO.ListaCliente();
        }

        public void NuevoCliente(ClientesCE cli)
        {
            objDAO.NuevoCliente(cli);
        }
    }
}
