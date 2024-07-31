// VanillaVehiclesRemixed
// https://github.com/qstar-inc/cities2-SimpleModChecker
// StarQ 2024

using Colossal.IO.AssetDatabase;
using Colossal.Logging;
using Game.Modding;
using Game.SceneFlow;
using Game;
using Unity.Entities;

namespace VanillaVehiclesRemixed
{
    public class Mod : IMod
    {
        public static string ModName = "Vanilla Vehicles Remixed";
        public static string Version = "2.0.0";
        public static string Author = "StarQ";

        //public static Setting m_Setting;

        //public static ILog log = LogManager.GetLogger($"{nameof(VanillaVehiclesRemixed)}").SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            //log.Info(nameof(OnLoad));

            //if (GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset))
            //log.Info($"Current mod asset at {asset.path}");
            
            //m_Setting = new Setting(this);
            //m_Setting.RegisterInOptionsUI();
            //GameManager.instance.localizationManager.AddSource("en-US", new LocaleEN(m_Setting));

            //AssetDatabase.global.LoadSettings(nameof(VanillaVehiclesRemixed), m_Setting, new Setting(this));
        }

        public void OnDispose()
        {
            //log.Info(nameof(OnDispose));
        }
    }
}
