using LiveCurrencyApp.Models;
using System.Net.Http.Json;

namespace LiveCurrencyApp.Services
{
    public class CurrencyService
    {
        private readonly HttpClient _httpClient;
        private const string API_URL = "https://open.er-api.com/v6/latest/USD";

        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CurrencyData?> GetExchangeRatesAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<CurrencyData>(API_URL);
            }
            catch
            {
                return null;
            }
        }
    }
}
