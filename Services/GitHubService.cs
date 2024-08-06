using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MyPortfolio.Models;

public class GitHubService
{
    private readonly HttpClient _httpClient;

    public GitHubService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Add("User-Agent", "request");
    }

    public async Task<List<GitHubRepo>> GetReposAsync(string username)
    {
        var repos = await _httpClient.GetFromJsonAsync<List<GitHubRepo>>($"https://api.github.com/users/{username}/repos");
        return repos;
    }
}
