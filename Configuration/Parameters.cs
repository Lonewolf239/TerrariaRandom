using CommandLine;
using TerrariaRandomizer.Data;

namespace TerrariaRandomizer.Configuration;

public class Parameters
{
    public int Count { get; private set; } = 1;
    public int MaxAnimationFrames { get; private set; } = 150;
    public int MinAnimationFrames => MaxAnimationFrames - 50;
    public bool UseWorldSize { get; private set; } = false;
    public bool UseDifficulty { get; private set; } = false;
    public bool Fast { get; private set; } = false;
    public bool OnlyVanilla { get; private set; } = false;
    public bool OnlyCalamity { get; private set; } = false;
    public bool UseSeeds { get; private set; } = false;
    public bool UseChallenges { get; private set; } = false;
    public bool NoAscii { get; private set; } = false;
    public List<string> DisabledClasses { get; private set; } = new();
    public string Language { get; private set; } = "en";

    public Parameters(string[] args)
    {
        var parser = new Parser(with =>
        {
            with.HelpWriter = null;
            with.AutoHelp = false;
            with.AutoVersion = false;
        });
        var parserResult = parser.ParseArguments<Options>(args).MapResult(options =>
        {
            if (!ParameterValidation(options)) return 1;
            SetParameters(options);
            if (options.Settings)
            {
                options = Settings.SettingsUI.Show(options);
                SetParameters(options);
                UI.Clear();
            }
            UI.Language = Language = Localization.GetCode(options.Language);
            List<string> disabledClasses = new();
            if (options.DisabledClasses?.Any() == true) disabledClasses = DisableClasses(options.DisabledClasses.Distinct().ToList());
            if (options.EnabledClasses?.Any() == true) disabledClasses = DisableClasses(options.EnabledClasses.Distinct().ToList(), false);
            DisabledClasses = disabledClasses;
            if (options.Help) UI.PrintHelp();
            if (options.Version) UI.PrintVersion();
            if (options.ListClasses) UI.PrintListClasses(Constants.Classes.ToList());
            if (options.ListLanguages) UI.PrintListLanguages(Localization.GetLanguagesWithName());
            return 0;
        },
        errors =>
        {
            UI.PrintError("Parameters.InvalidInput.Error".Localize(Language));
            return -1;
        });
    }

    private void SetParameters(Options options)
    {
        if (options.Count > 1) options.Fast = true;
        Count = options.Count;
        MaxAnimationFrames = options.MaxAnimationFrames;
        Fast = options.Fast;
        OnlyVanilla = options.OnlyVanilla;
        OnlyCalamity = options.OnlyCalamity;
        UseSeeds = options.UseSeeds;
        UseChallenges = options.UseChallenges;
        UseWorldSize = options.UseWorldSize;
        UseDifficulty = options.UseDifficulty;
        UI.NoAscii = NoAscii = Program.IsBeyondAsciiRange || options.NoAscii;
        if (options.NoColor) UI.NoColor();
        else UI.UseColor();
    }

    private static List<string> DisableClasses(List<string> classes, bool disable = true)
    {
        if (disable) return classes.Where(c => Constants.Classes.Contains(c, StringComparer.OrdinalIgnoreCase)).ToList();
        else
        {
            var validEnabled = classes.Where(c => Constants.Classes.Contains(c, StringComparer.OrdinalIgnoreCase)).ToList();
            return Constants.Classes.Except(validEnabled, StringComparer.OrdinalIgnoreCase).ToList();
        }
    }

    private static bool ParameterValidation(Options options)
    {
        if (!Localization.GetLanguages().Contains(Localization.GetCode(options.Language)))
        {
            UI.PrintError("Parameters.Language.Error".Localize("en"));
            return false;
        }
        if (options.Count > 12)
        {
            UI.PrintError("Parameters.Count.Error".Localize(options.Language));
            return false;
        }
        if (options.MaxAnimationFrames < 55)
        {
            UI.PrintError("Parameters.MaxAnimationFrames.Error".Localize(options.Language));
            return false;
        }
        if (options.OnlyVanilla && options.OnlyCalamity)
        {
            UI.PrintError("Parameters.Only.Error".Localize(options.Language));
            return false;
        }
        if (options.DisabledClasses?.Any() == true && options.EnabledClasses?.Any() == true)
        {
            UI.PrintError("Parameters.Classes.Error".Localize(options.Language));
            return false;
        }
        if (options.DisabledClasses?.Any() == true)
        {
            var disabledClasses = options.DisabledClasses.Distinct().ToList();
            var invalidClasses = disabledClasses.Where(c => !Constants.Classes.Contains(c, StringComparer.OrdinalIgnoreCase)).ToList();
            if (invalidClasses.Any())
            {
                UI.PrintError("Parameters.InvalidClasses.Error".Localize(options.Language) + string.Join(", ", invalidClasses));
                return false;
            }
            if (disabledClasses.Count == Constants.Classes.Length)
            {
                UI.PrintError("Parameters.AllClassesDisabled.Error".Localize(options.Language));
                return false;
            }
        }
        if (options.EnabledClasses?.Any() == true)
        {
            var enabledClasses = options.EnabledClasses.Distinct().ToList();
            var invalidClasses = enabledClasses.Where(c => !Constants.Classes.Contains(c, StringComparer.OrdinalIgnoreCase)).ToList();
            if (invalidClasses.Any())
            {
                UI.PrintError("Parameters.InvalidClasses.Error".Localize(options.Language) + string.Join(", ", invalidClasses));
                return false;
            }
        }
        return true;
    }
}
