using Statiq.App;
using Statiq.Common;
using Statiq.Web;
using System.Threading.Tasks;

namespace BishopClassicMotors
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await Bootstrapper
                .Factory
                .CreateWeb(args)
                .DeployToGitHubPagesBranch(
                    "withinfocus",
                    "withinfocus.github.io",
                    Config.FromSetting<string>("GITHUB_TOKEN"),
                    "main"
                )
                .RunAsync();
        }
    }
}
