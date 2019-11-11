using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiLibreria
{
    public class Utilidades
    {

        public static DataSet EjecutarSql(String CmdSql) {

            SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
            conexion.Open();
            DataSet data = new DataSet();
            SqlDataAdapter adapterSql = new SqlDataAdapter(CmdSql, conexion);
            adapterSql.Fill(data);

            conexion.Close();
            return data;
        }
    }
}
