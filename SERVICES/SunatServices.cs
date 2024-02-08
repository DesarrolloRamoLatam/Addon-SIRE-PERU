using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Sire;

namespace Services
{
	public class SunatServices
	{
		private string baseUrl = "https://api-seguridad.sunat.gob.pe/v1/clientessol/a829dffc-466f-431d-a175-6d5e0b69401f/oauth2/token/";

		

		private static RespuestaToken GenerateTokenSunat() //Conexion oConexion
		{
			try
			{
				string url = "https://api-seguridad.sunat.gob.pe/v1/clientessol/a829dffc-466f-431d-a175-6d5e0b69401f/oauth2/token/";
				RespuestaToken respuestaToken = new RespuestaToken();
				var paramss = new Dictionary<string, string>();
				paramss.Add("grant_type", "password");
				paramss.Add("scope", "https://api-eeff.sunat.gob.pe/");
				paramss.Add("client_id", "a829dffc-466f-431d-a175-6d5e0b69401f");
				paramss.Add("client_secret", "9y/K/TAtO4NVxb1c7ppMTQ==");
				paramss.Add("username", "20263019807CPE00001");
				paramss.Add("password", "Cpe00001");



				using (var httpClientHandler = new HttpClientHandler())
				{
					System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;
					using (var httpClient = new HttpClient(httpClientHandler))
					{
						httpClient.Timeout = TimeSpan.FromSeconds(60000);
						var result = httpClient.PostAsync(new Uri(url), new FormUrlEncodedContent(paramss)).Result;
						var resultContent2 = result.Content.ReadAsStringAsync().Result;
						respuestaToken = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaToken>(resultContent2);
					}
				}

				return respuestaToken;
			}
			catch (Exception ex)
			{
				//Log.Info("Error GenerateTokenSunat : " + ex.ToString());
				return null;
			}


		}

		public List<Registros> GetRegistrosSireVenta()
		{
			try
			{
				string url = "https://api-sire.sunat.gob.pe/v1/contribuyente/migeigv/libros/rvie/propuesta/web/propuesta/202401/comprobantes?codTipoOpe=2&mtoDesde=&mtoHasta=&fecEmisionIni=&fecEmisionFin=&numDocAdquiriente=&codCar=&codTipoCDP=&codInconsistencia=&page=1&perPage=20";


				return null;
			}
			catch (Exception)
			{

				throw;
			}
			
		}


	}
}
