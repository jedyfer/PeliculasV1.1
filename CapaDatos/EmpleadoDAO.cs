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
    public class EmpleadoDAO
    {
        SqlConnection cn;
        Conexion objCon = new Conexion();

        public DataTable ListaEmpleado()
        {
            cn = objCon.getConecta();

            SqlDataAdapter da = new SqlDataAdapter("sp_ListaEmpleados", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void NuevoEmpleado(EmpleadoCE emp)
        {
            cn = objCon.getConecta();
            cn.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "sp_NuevoEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;

            cmd.Parameters.Add("@cod", SqlDbType.NVarChar).Value = emp.empCodigo;
            cmd.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = emp.emp_Apellidos;
            cmd.Parameters.Add("@nombres", SqlDbType.NVarChar).Value = emp.emp_Nombres;
            cmd.Parameters.Add("@direc", SqlDbType.NVarChar).Value = emp.empDireccion;
            cmd.Parameters.Add("@lugar", SqlDbType.NVarChar).Value = emp.emp_lugar;
            cmd.Parameters.Add("@fono", SqlDbType.NVarChar).Value = emp.empTelefono;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = emp.empE_mail;
            cmd.Parameters.Add("@fing", SqlDbType.DateTime).Value = emp.emp_feching;
            cmd.Parameters.Add("@fnac", SqlDbType.DateTime).Value = emp.empFechNac;
            cmd.Parameters.Add("@sueldo", SqlDbType.Int).Value = emp.empSueldo;

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
