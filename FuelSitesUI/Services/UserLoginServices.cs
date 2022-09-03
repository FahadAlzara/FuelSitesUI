using System.Text;
using FuelSitesUI.Models;

namespace FuelSitesUI.Services
{
    public class UserLoginServices
    {
      private readonly  HttpClient _httpClient;

        public UserLoginServices()
        {
            _httpClient = new HttpClient();
        }

        public async Task<bool> Add(UserLoginDTO user)
        {
            var url = "https://localhost:7062/api/UserLogin/NewUser";

            string json = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);

            if(response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
            
        }

        public async Task<bool> Update(UserLoginDTO user)
        {
            var url = "https://localhost:7062/api/UserLogin";

            string json = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(UserLoginDTO user)
        {
            var url = "https://localhost:7062/api/UserLogin";

            var json = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Login(UserLoginDTO user)
        {
            var url = "https://localhost:7062/api/UserLogin";

            var json = JsonSerializer.Serialize(user);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;


        }
    }
}