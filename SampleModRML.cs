using Elements.Core;
using FrooxEngine;
using FrooxEngine.UIX;
using HarmonyLib; // HarmonyLib comes included with a ResoniteModLoader install
using ResoniteModLoader;

namespace SampleMod
{
    /// <summary>
    /// This mod is an implementation based on the example given in https://github.com/resonite-modding-group/ResoniteModLoader/blob/main/doc/making_mods.md.
    /// </summary>
    public class SampleModRML : ResoniteMod
    {
        public override string Name => "SampleMod";
        public override string Author => "mpmxyz";
        public override string Version => "1.0.0"; //Version of the mod, should match the AssemblyVersion
        public override string Link => "https://github.com/mpmxyz/ResoniteSampleMod";

        //The following
        [AutoRegisterConfigKey]
        private static readonly ModConfigurationKey<bool> enabled = new ModConfigurationKey<bool>("enabled", "Should the mod be enabled", () => true); //Optional config settings

        private static ModConfiguration Config;//If you use config settings, this will be where you interface with them

        public override void OnEngineInit()
        {
            Config = GetConfiguration(); //Get this mods' current ModConfiguration
            Config.Save(true); //If you'd like to save the default config values to file
            Harmony harmony = new Harmony("com.github.mpmxyz.SampleMod"); //typically a reverse domain name is used here (https://en.wikipedia.org/wiki/Reverse_domain_name_notation)
            harmony.PatchAll(); // do whatever LibHarmony patching you need, this will patch all [HarmonyPatch()] instances

            //Various log methods provided by the mod loader, below is an example of how they will look
            //3:14:42 AM.069 ( -1 FPS)  [INFO] [ResoniteModLoader/SampleMod] a regular log
            Debug("a debug log");
            Msg("a regular log");
            Warn("a warn log");
            Error("an error log");
        }

        //Example of how a HarmonyPatch can be formatted
        [HarmonyPatch(typeof(Button), "OnPressBegin")]
        class ClassName_MethodName_Patch
        {
            //Postfix() here will be automatically applied as a PostFix Patch
            [HarmonyPostfix]
            static void Postfix(Button __instance, Canvas.InteractionData eventData)
            {
                if (!Config.GetValue(enabled))
                {//Use Config.GetValue() to use the ModConfigurationKey defined earlier
                    return; //In this example if the mod is not enabled, we'll just return before doing anything
                }
                Warn("Hello World!");
                FrooxEngineBootstrap.LogStream.Flush();
                //Do stuff after everything in the original OnPressBegin has run.
            }
        }
    }
}
