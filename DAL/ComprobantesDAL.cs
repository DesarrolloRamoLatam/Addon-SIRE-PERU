using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class ComprobantesDAL
	{
		private ConexionBD conexionBD;

		public ComprobantesDAL()
		{
			
			this.conexionBD = new ConexionBD("");
		}

		public DataTable GetComprobantes()
		{
			string consulta = "SELECT * FROM OINV...";
			return conexionBD.EjecutarConsulta(consulta);
		}
	}
}
