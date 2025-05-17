using StardewModdingAPI;

namespace Pathoschild.Stardew.TestModAddedPath
{
    /// <inheritdoc />
    public class ModEntry : Mod
    {
        /// <inheritdoc />
        public override void Entry(IModHelper helper)
        {
            I18n.Init(helper.Translation);
            I18n.SharedItem();
            I18n.ExtraPath();
        }
    }
}
