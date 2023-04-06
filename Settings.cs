using ModSettings;

namespace AlternativeActionUtilities
{
	internal class Settings : JsonModSettings
	{
		internal static Settings instance = new Settings();

		[Name("Tertiary Key Code")]
		[Description("The key for tertiary actions. Does nothing unless a mod uses this feature.")]
		public UnityEngine.KeyCode tertiaryKeyCode = UnityEngine.KeyCode.Mouse2;
	}
}