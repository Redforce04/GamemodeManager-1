using Exiled.API.Enums;
using Exiled.API.Features;
using System;

namespace GamemodeManager
{
    public class Loader : Plugin<Config>
    {
        public override string Author => "Zereth";
        public override string Name => "GamemodeManager";
        public override string Prefix => "gamemode_manager";
        public override PluginPriority Priority => PluginPriority.Default;
        public override Version RequiredExiledVersion => new Version(3, 0, 5);
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }
    }
}
