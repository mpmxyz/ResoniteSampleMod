
using MonkeyLoader.Configuration;
using MonkeyLoader.Resonite;
using System;

namespace SampleMod
{
    /// <summary>
    /// This mod is an implementation based on the example given in https://github.com/resonite-modding-group/ResoniteModLoader/blob/main/doc/making_mods.md.
    /// </summary>
    public class SampleModMonkey : ResoniteMonkey<SampleModMonkey>, ISampleMod
    {
        public override string Name => "SampleMod";

        private readonly SampleModMonkeyConfig LoadedConfig = Config.LoadSection<SampleModMonkeyConfig>();

        public bool Enabled => LoadedConfig.Enabled.GetValue();

        public void DoSomething()
        {
            Logger.Warn(() => "Hello World!");
        }

        protected override bool OnEngineReady()
        {
            Patches.Apply(this);
            return base.OnEngineReady();
        }

        protected override void OnEngineShutdownRequested(string reason)
        {
            base.OnEngineShutdownRequested(reason);
        }

        protected override bool OnLoaded()
        {
            return base.OnLoaded();
        }

        protected override bool OnShutdown()
        {
            return base.OnShutdown();
        }

        private class SampleModMonkeyConfig : ConfigSection
        {
            public DefiningConfigKey<bool> Enabled = new DefiningConfigKey<bool>("Enabled", "Enables a small message on each button click.", () => true);

            public override string Description => "MonkeyLoader flavor of sample mod's config";

            public override string Name => "SampleMod";

            public override Version Version => new Version(1, 0, 0);
        }
    }
}
