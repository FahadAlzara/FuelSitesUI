using FuelSitesUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelSitesUI.Services
{
    public class FuelSitesServices
    {
        private readonly HttpClient _httpClient;

        public FuelSitesServices()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<FuelSite>> GetAll()
        {
            
            List<FuelSite> sites = new List<FuelSite>();

            var url = "https://localhost:7062/api/FuelSites";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                sites = JsonSerializer.Deserialize<List<FuelSite>>(content);
            }

            return sites;

        }

        public async Task<bool> Add(FuelSite site)
        {
            var url = "https://localhost:7062/api/FuelSites";

            string json = JsonSerializer.Serialize(site);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<FuelSite> GetById(int id)
        {

            FuelSite site = new FuelSite();

            var url = $"https://localhost:7062/api/FuelSites/{id}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                site = JsonSerializer.Deserialize<FuelSite>(content);
            }

            return site;

        }


    }
}
