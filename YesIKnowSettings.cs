using UnityEngine;
using ModSettings;
using MelonLoader;

namespace YesIKnow
{
    internal class YesIKnowSettings : JsonModSettings
    {        
        [Section("Hovertext")]
     
        [Name("General items")]
        [Description("Enable/disable hovertext on items")]
        public bool hoverGeneral = false;

        [Name("Fire")]
        [Description("Enable/disable hovertext on fire / stoves")]
        public bool hoverFire = false;

        protected override void OnConfirm()
        {
            base.OnConfirm();
        }
    }

    internal static class Settings
    {
        public static YesIKnowSettings options;

        public static void OnLoad()
        {
            options = new YesIKnowSettings();
            options.AddToModSettings("Yes I Know");
        }
    }
}
