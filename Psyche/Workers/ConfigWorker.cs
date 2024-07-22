using Psyche.Models;

namespace Psyche.Workers
{
    public class ConfigWorker
    {
        public Config GetConfig()        // todo
        {
            Config Config = Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(File.ReadAllText("appsettings.json"));
            if (Config is not null)
            {
                return Config;
            }
            else
            {
                throw new Exception("Config is null");
            }
        }
    }
}
