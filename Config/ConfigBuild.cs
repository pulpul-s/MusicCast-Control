using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace MusicCast_Control.Config
{
    internal class ConfigBuild
    {
        public string ConfigPath { get; set; } = "Config.json";
        public ConfigTemplate Config { get; set; }

        public async Task InitializeAsync()
        {
            var json = string.Empty;

            if (!File.Exists(ConfigPath))
            {
                json = JsonConvert.SerializeObject(GenerateNewConfig(), Formatting.Indented);
                File.WriteAllText("Config.json", json, new UTF8Encoding(false));
                await Task.Delay(-1);
            }

            json = File.ReadAllText(ConfigPath, new UTF8Encoding(false));
            Config = JsonConvert.DeserializeObject<ConfigTemplate>(json);
        }

        private ConfigTemplate GenerateNewConfig() => new ConfigTemplate
        {
            IP = "IP",
        };
    }
}
