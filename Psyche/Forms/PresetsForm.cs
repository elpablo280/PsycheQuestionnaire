using Psyche.Models;
using Psyche.Workers;

namespace Psyche.Forms
{
    public partial class PresetsForm : Form
    {
        private string[] TestFilepaths;
        private readonly Config Config;
        public readonly MainMenu MainMenu;
        private Preset Preset;

        public PresetsForm(Config config, MainMenu mainMenu)
        {
            InitializeComponent();
            Config = config;
            MainMenu = mainMenu;

            string[] presets = Directory.GetFiles(Config.PresetsFilepath);

            int i = 1;
            foreach (string preset in presets)
            {
                FileInfo fileInfo = new(preset);
                string presetName = fileInfo.Name.Replace(".json", string.Empty);        // todo

                Button Button = new()
                {
                    Location = new Point(10, 30 * i),
                    Text = presetName,
                    Width = 200,
                    //AutoSize = true,
                    //AutoSizeMode = AutoSizeMode.GrowOnly
                };
                Button.Click += (sender, EventArgs) =>
                {
                    // парсим пресет из файла
                    PresetParser pp = new();
                    Preset = pp.ParsePreset(fileInfo.FullName);

                    TestFilepaths = Preset.TestFilepaths;

                    //foreach (var test in Preset.TestFilepaths.ToList())
                    //{
                    //    TestsQueue.Enqueue(test);
                    //}

                    TestsMenuForm testsMenuForm = new(Config, MainMenu, TestFilepaths);
                };
                Controls.Add(Button);
                i++;
            }
        }
    }
}
