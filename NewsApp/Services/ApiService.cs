using Newtonsoft.Json;
using NewsApp.Models;

namespace NewsApp.Services;

public class ApiService
{
	public async Task<Root> GetNews(string categoryName)
	{
		var httpClient = new HttpClient();
		var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category={categoryName.ToLower()}&apikey=bd29be10beccb4e2f05a3214d8bdb55b&lang=zh");
		return JsonConvert.DeserializeObject<Root>(response);
	}
}