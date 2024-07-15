using Psyche.Models;

namespace Psyche.Workers
{
    public class ConfigWorker
    {
        public Config? GetConfig()
            => Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(File.ReadAllText("appsettings.json"));

    }
}
