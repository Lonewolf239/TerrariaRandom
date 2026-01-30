using Spectre.Console;
using TerrariaRandomizer.Configuration;
using TerrariaRandomizer.Data;

namespace TerrariaRandomizer;

public static class UI
{
    public static bool NoAscii = false;
    public static string Language = "en";

    public static void PrintTitle()
    {
        if (NoAscii)
        {
            PrintTitleNoAscii();
            return;
        }
        string title = Constants.AsciiArt;
        string[] lines = title.Split('\n');
        foreach (string line in lines) AnsiConsole.MarkupLine(line);
        Console.WriteLine('\n');
    }

    public static void PrintTitleNoAscii()
    {
        AnsiConsole.MarkupLine("[lime]Terraria Random[/]\n[yellow]By.Lonewolf239[/] [grey]v" + Constants.Version + "[/]");
        Console.WriteLine('\n');
    }

    public static void PrintVersion()
    {
        Console.CursorVisible = true;
        PrintTitleNoAscii();
        Environment.Exit(0);
    }

    public static void Clear() => AnsiConsole.Clear();

    public static void UseColor() => AnsiConsole.Profile.Capabilities.ColorSystem = ColorSystem.TrueColor;

    public static void NoColor() => AnsiConsole.Profile.Capabilities.ColorSystem = ColorSystem.NoColors;

    public static void PrintError(string message)
    {
        Console.CursorVisible = true;
        AnsiConsole.MarkupLine("UI.Error".Localize(Language) + message);
        Environment.Exit(1);
    }

    public static void PrintRule()
    {
        string title = "UI.Rule.Title".Localize(Language);
        string subTitle = "UI.Rule.SubTitle".Localize(Language);
        var rule = new Rule("[silver]" + title + "[/]");
        rule.Style = Style.Parse("grey");
        var subRule = new Rule("[silver]" + subTitle + "[/]");
        subRule.Style = Style.Parse("grey");
        AnsiConsole.Write(rule);
        AnsiConsole.Write(subRule);
    }

    public static void PrintHelp()
    {
        Console.CursorVisible = true;
        PrintTitleNoAscii();
        AnsiConsole.MarkupLine("UI.Help.Options".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.Help".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.Settings".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.Count".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.MaxAnimationFrames".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.Fast".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.OnlyVanilla".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.OnlyCalamity".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.UseSeeds".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.UseChallenges".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.UseWorldSize".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.UseDifficulty".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.NoAscii".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.NoColor".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.DisableClasses".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.EnableClasses".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.ListClasses".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.Language".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Options.Languages".Localize(Language));
        Console.WriteLine();
        AnsiConsole.MarkupLine("UI.Help.Examples".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Examples.Example1".Localize(Language));
        AnsiConsole.MarkupLine("UI.Help.Examples.Example2".Localize(Language));
        Console.WriteLine();
        Environment.Exit(0);
    }

    public static void PrintListClasses(List<string> classes)
    {
        Console.CursorVisible = true;
        PrintTitleNoAscii();
        AnsiConsole.MarkupLine("UI.Classes".Localize(Language));
        foreach (var item in classes)
            AnsiConsole.MarkupLine($"  [green]{item}[/]");
        Console.WriteLine();
        Environment.Exit(0);
    }

    public static void PrintListLanguages(List<string> languages)
    {
        Console.CursorVisible = true;
        PrintTitleNoAscii();
        AnsiConsole.MarkupLine("UI.Language".Localize(Language));
        foreach (var item in languages)
            AnsiConsole.MarkupLine($"  [green]{item}[/]");
        Console.WriteLine();
        Environment.Exit(0);
    }

    private static string Colorize(string value, string color) => $"[{color}]{value}[/]";

    private static string GetColor(string[] arrayColors, string[] array, string value) => arrayColors[Array.IndexOf(array, value)];

    private static void PrintAligned(IEnumerable<(string label, string value)> rows, int baseGap = 2)
    {
        int maxLabelLen = rows.Max(r => r.label.Length);
        foreach (var (label, value) in rows)
        {
            int spaces = baseGap + (maxLabelLen - label.Length);
            AnsiConsole.MarkupLine($"[grey]{label}:[/] {new string(' ', spaces)}{value}{new string(' ', 25)}");
        }
    }

    public static void PrintResults(Parameters parameters, GenerationResult generationResult)
    {
        string gameTypeColor = GetColor(Constants.GameTypeColors, Constants.GameTypes, generationResult.GameType);
        string classColor = GetColor(Constants.ClassColors, Constants.Classes, generationResult.CharacterClass);
        string evilColor = GetColor(Constants.ContagionColors, Constants.Contagions, generationResult.Evil);
        string challengeColor = GetColor(Constants.ChallengeColors, Constants.Challenges, generationResult.Challenge);
        string seedColor = GetColor(Constants.SpecialSeedColors, Constants.SpecialSeeds, generationResult.Seed);
        string mapSizeColor = GetColor(Constants.MapSizeColors, Constants.MapSizes, generationResult.MapSize);
        string difficultyColor = GetColor(Constants.DifficultyColors, Constants.Difficultys, generationResult.Difficulty);
        string calamityDifficultyColor = GetColor(Constants.CalamityDifficultyColors, Constants.CalamityDifficultys, generationResult.CalamityDifficulty);
        string worldName = $"{generationResult.Name}'s world";
        string difficulty = generationResult.GameType == "Vanilla"
            ? Colorize(generationResult.Difficulty, difficultyColor)
            : $"{Colorize(generationResult.CalamityDifficulty, calamityDifficultyColor)}+{Colorize(generationResult.Difficulty, difficultyColor)}";
        var rows = new List<(string label, string value)>
        {
            ("UI.Results.GameVersion".Localize(Language), Colorize(generationResult.GameType, gameTypeColor)),
            ("UI.Results.Name".Localize(Language), Colorize(generationResult.Name, "white")),
            ("UI.Results.WorldName".Localize(Language), Colorize(worldName, "gold1")),
            ("UI.Results.Class".Localize(Language), Colorize(generationResult.CharacterClass, classColor)),
            ("UI.Results.WorldEvil".Localize(Language), Colorize(generationResult.Evil, evilColor)),
        };
        if (parameters.UseChallenges) rows.Add(("UI.Results.Challenge".Localize(Language), Colorize(generationResult.Challenge, challengeColor)));
        if (parameters.UseSeeds) rows.Add(("UI.Results.Seed".Localize(Language), Colorize(generationResult.Seed, seedColor)));
        rows.Add(("UI.Results.MapSize".Localize(Language), Colorize(generationResult.MapSize, mapSizeColor)));
        rows.Add(("UI.Results.Difficulty".Localize(Language), difficulty));
        PrintAligned(rows);
    }
}
