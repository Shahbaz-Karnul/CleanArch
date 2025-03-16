using System.Security.AccessControl;
using System.Text.Json.Serialization;
using Journal.Web.Models.Salat;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Azure;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http.Headers;
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

		public async Task AddAsync(SalatModel salat)


		{
          _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _httpClient.PostAsJsonAsync("https://localhost:7176/api/Salat", salat);

			response.EnsureSuccessStatusCode();

			//return RedirectToAction(nameof(Index));

		}
	}
}
