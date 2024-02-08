using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using DTO.Sire;
namespace BLL
{
	public class SireBLL
	{
		private SunatServices sunatService;

		public List<Registros> GetRegistrosSireVenta()
		{
			return sunatService.GetRegistrosSireVenta();
		}


	}
}
