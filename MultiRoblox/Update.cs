using System.Diagnostics;
using System.Net.Http.Json;

namespace MultiRoblox
{
    internal class Update
    {
        string version = "v1.0.0";
        string repo = "Dlunhappy226/MultiRoblox";

        public bool CheckUpdate()
        {
            HttpClient HttpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.github.com")
            };
            HttpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; MultiRoblox)");

            try
            {
                var request = Task.Run(() => HttpClient.GetFromJsonAsync<Dictionary<string, object>>($"repos/{repo}/releases/latest"));
                request.Wait();

                if (request.Result == null) { return false; }

                Dictionary<string, object> response = request.Result;

                response.TryGetValue("tag_name", out object? latestVersion);

                if (latestVersion == null) { return false; }

                if (latestVersion.ToString() == version)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void UpdatetoNewVersion()
        {
            Process process = new Process();
            process.StartInfo.FileName = "powershell.exe";
            process.StartInfo.Arguments = "iwr https://raw.githubusercontent.com/Dlunhappy226/MultiRoblox/main/install.ps1 | iex";
            process.StartInfo.CreateNoWindow = true;
            process.Start();
        }
    }
}
