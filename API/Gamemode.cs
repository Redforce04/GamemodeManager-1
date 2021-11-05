using Exiled.API.Features;
namespace GamemodeManager.API
{
    public abstract class Gamemode
    {
        public abstract string Name { get; }
        public abstract Dictionary<string, List<Player>> { get; set; }
    }
}
