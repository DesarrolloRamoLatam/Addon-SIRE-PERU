using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Sire
{
	public class Auditoria
	{
		public string codUsuRegis { get; set; }
		public DateTime fecRegis { get; set; }
		public string codUsuModif { get; set; }
		public DateTime fecModif { get; set; }
	}
}
