using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class AvalaDAO
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();

        public DataTable LlenarAvalas()
        {
            cn = objCon.getConecta();
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tblmvTelefonoCliente", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
