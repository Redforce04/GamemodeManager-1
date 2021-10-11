using Exiled.API.Enums;
using Exiled.API.Features;
using GamemodeManager.API;
using System;
using System.Collections.Generic;

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

        public static bool Loaded { get; private set; } = false;

        public static List<Gamemode> Gamemodes { get; private set; }

        public override void OnEnabled()
        {
            LoadGamemodes();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }

        private static void LoadGamemodes()
        {
            if (!Loaded)
            {
                // Load gamemodes here.

                Loaded = true;
            }
        }
    }
}
