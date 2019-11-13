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

            //dataSet para que almacene lo que quiero
            DataSet data = new DataSet();

            //sqlAdapter para adaptar los datos y que me devuelva la consulta a dataSet
            SqlDataAdapter adapterSql = new SqlDataAdapter(CmdSql, conexion);
            //rellena el dataSet creado
            adapterSql.Fill(data);

            conexion.Close();
            return data;
        }
    }
}
