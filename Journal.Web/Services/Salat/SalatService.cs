using System.Security.AccessControl;
using System.Text.Json.Serialization;
using Journal.Web.Models.Salat;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
namespace Journal.Web.Services.Salat
{
	public class SalatService
	{
		private readonly HttpClient _httpClient;
	

		public SalatService(HttpClient httpClient)
		{ 
		   _httpClient = httpClient;
		}

		public async Task<List<SalatModel>> GetAll()

		{
			var response = await _httpClient.GetAsync("https://localhost:7176/api/Salat");

			response.EnsureSuccessStatusCode();

			var content = await response.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<List<SalatModel>>(content);
		}
	}
}
