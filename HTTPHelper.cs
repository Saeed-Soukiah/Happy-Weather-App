using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather_App
{
    // Simple helper using HttpClient and async methods.
    public class HTTPHelper : IDisposable
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        // Asynchronously fetch JSON from the provided URL and return it as string.
        public async Task<string> GetJsonAsync(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("URL must not be empty.", nameof(url));

            using (var response = await _httpClient.GetAsync(url).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        // If you prefer not to use Dispose, you can remove IDisposable and Dispose implementation.
        public void Dispose()
        {
            // Do not dispose the static HttpClient here.
            // This class implements IDisposable only for symmetry if you later add disposable members.
        }
    }
}