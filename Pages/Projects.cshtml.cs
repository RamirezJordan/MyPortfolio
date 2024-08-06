using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolio.Models;

public class ProjectsModel : PageModel
{
    private readonly GitHubService _gitHubService;

    public ProjectsModel(GitHubService gitHubService)
    {
        _gitHubService = gitHubService;
    }

    public List<GitHubRepo> Repos { get; set; }

    public async Task OnGetAsync()
    {
        Repos = await _gitHubService.GetReposAsync("ramirezjordan");
    }
}
