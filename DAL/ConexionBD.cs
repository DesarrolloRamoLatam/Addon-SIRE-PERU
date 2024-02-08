using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class ConexionBD
	{
		private string cadenaConexion;
		private SqlConnection conexion;

		public ConexionBD(string connectionString)
		{
			this.cadenaConexion = connectionString;
			this.conexion = new SqlConnection(cadenaConexion);
		}

		public void AbrirConexion()
		{
			if (conexion.State == ConnectionState.Closed)
			{
				conexion.Open();
			}
		}

		public void CerrarConexion()
		{
			if (conexion.State == ConnectionState.Open)
			{
				conexion.Close();
			}
		}

		public DataTable EjecutarConsulta(string consulta)
		{
			AbrirConexion();
			DataTable dataTable = new DataTable();

			try
			{
				using (SqlCommand cmd = new SqlCommand(consulta, conexion))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
					{
						adapter.Fill(dataTable);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
			}
			finally
			{
				CerrarConexion();
			}

			return dataTable;
		}
		
		public void EjecutarComando(string comando)
		{
			AbrirConexion();

			try
			{
				using (SqlCommand cmd = new SqlCommand(comando, conexion))
				{
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al ejecutar el comando: " + ex.Message);
			}
			finally
			{
				CerrarConexion();
			}
		}
	}
}

