using Newtonsoft.Json;
using Paises.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Paises.Services
{
  public class ApiService
    {
        public async Task<Response> GetCountries(string urlBase, string controller)
        {
			try
			{
				var cliente = new HttpClient();
				cliente.BaseAddress = new Uri(urlBase);

				var response = await cliente.GetAsync(controller);


				var result = await response.Content.ReadAsStringAsync();

				//colocar um break para ver se está bem desserializado
				if (!response.IsSuccessStatusCode)
				{
					return new Response
					{
						IsSuccess = false,
						Message = result
					};
				}
				var settings = new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore,
					MissingMemberHandling = MissingMemberHandling.Ignore
				};

				var paises = JsonConvert.DeserializeObject<List<Pais>>(result, settings);

				return new Response
				{
					IsSuccess = true,
					Result = paises
				};

			}
			catch (Exception e)
			{

				return new Response
				{
					IsSuccess = false,
					Message = e.Message
				};
			}
        }
    }
}
