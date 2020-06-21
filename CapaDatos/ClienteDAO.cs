using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class ClienteDAO
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();

        public DataTable ListaCliente()
        {
            cn = objCon.getConecta();

            SqlDataAdapter da = new SqlDataAdapter("sp_ListaClientes", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void NuevoCliente(ClientesCE cli)
        {
            cn = objCon.getConecta();
            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_NuevoCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@cod", SqlDbType.NVarChar).Value = cli.cliCodigo;
            cmd.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = cli.cliApellidos;
            cmd.Parameters.Add("@nombres", SqlDbType.NVarChar).Value = cli.cliNombres;
            cmd.Parameters.Add("@genero", SqlDbType.NVarChar).Value = cli.cliGenero;
            cmd.Parameters.Add("@fnac", SqlDbType.DateTime).Value = cli.cliFechNac;
            cmd.Parameters.Add("@direc", SqlDbType.NVarChar).Value = cli.cliDireccion;
            cmd.Parameters.Add("@lugar", SqlDbType.NVarChar).Value = cli.cliLugar;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = cli.cliEmail;
            cmd.Parameters.Add("@fing", SqlDbType.DateTime).Value = cli.cliFechInsc;
            cmd.Parameters.Add("@avala", SqlDbType.NVarChar).Value = cli.cliAvala;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
    }
}
