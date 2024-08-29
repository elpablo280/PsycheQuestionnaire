using Psyche.Models;

namespace Psyche.Workers
{
    public class PresetParser
    {
        public PresetParser()
        {
        }

        public Preset ParsePreset(string filePath)
        {
            Preset preset = Newtonsoft.Json.JsonConvert.DeserializeObject<Preset>(File.ReadAllText(filePath));
            if (preset is not null)
            {
                return preset;
            }
            else
            {
                throw new Exception($"Parsed preset is null from filepath: {filePath}");
            }
        }
    }
}
