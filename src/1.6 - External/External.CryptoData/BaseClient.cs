namespace External.CryptoData
{
    public abstract class BaseClient
    {
        public async Task<string> GetContent(string url)
        {
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();                
            }
            catch (HttpRequestException e)
            {
                throw new Exception($"{e}");
            }
        }
    }
}