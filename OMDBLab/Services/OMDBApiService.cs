namespace OMDBLab.Services
{
    public class OMDBApiService
    {
        private readonly HttpClient _httpClient;
        public OMDBApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        

    }
}
