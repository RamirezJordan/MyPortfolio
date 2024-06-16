using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MyPortfolio.Pages
{
    public class UserModel : PageModel
    {
        public User User { get; set; }

        public async Task OnGetAsync()
        {
            using HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
            };

            User = await client.GetFromJsonAsync<User>("users/2");
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Phone {get; set;}
        public string? Website { get; set; }
        public Company Company { get; set; }
    }

    public class Company 
    {
        public string? Name {get; set;}
        public string? CatchPhrase { get; set;}
        public string? Bs { get; set; }
    }
}