using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MyPortfolio.Pages
{
    public class GitHubUserModel : PageModel
    {
        public GitHubUser GitHubUser { get; set; }

        public async Task OnGetAsync()
        {
            using HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://api.github.com/")
            };

            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request"); // Necesario para evitar un error de GitHub API

            GitHubUser = await client.GetFromJsonAsync<GitHubUser>("users/ramirezjordan");
        }
    }

    public class GitHubUser
    {
        public string? Login { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Blog { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public string? AvatarUrl { get; set; }
    }
}