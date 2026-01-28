using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;

namespace TerrariaRandomizer;

public class Options
{
    [Option("help")]
    public bool Help { get; set; }

    [Option("version")]
    public bool Version { get; set; }

    [Option("count", Default = 1)]
    public int Count { get; set; }

    [Option("maxAnimationFrames", Default = 150)]
    public int MaxAnimationFrames { get; set; }

    [Option("fast", Default = false)]
    public bool Fast { get; set; }

    [Option("onlyVanilla", Default = false)]
    public bool OnlyVanilla { get; set; }

    [Option("onlyCalamity", Default = false)]
    public bool OnlyCalamity { get; set; }

    [Option("useSeeds", Default = false)]
    public bool UseSeeds { get; set; }

    [Option("useChallenges", Default = false)]
    public bool UseChallenges { get; set; }

    [Option("useWorldSize", Default = false)]
    public bool UseWorldSize { get; set; }

    [Option("useDifficulty", Default = false)]
    public bool UseDifficulty { get; set; }

    [Option("noAscii", Default = false)]
    public bool NoAscii { get; set; }

    [Option("noColor", Default = false)]
    public bool NoColor { get; set; }

    [Option("disableClasses", Separator = ',')]
    public IEnumerable<string> DisabledClasses { get; set; }

    [Option("listClasses")]
    public bool ListClasses { get; set; }

    [Option("ru", Default = false)]
    public bool Russian { get; set; }
}

public class Parameters
{
    public readonly string[] Names =
    {
        "Alex", "Nick", "Steve", "Max", "John", "Michael", "David",
        "James", "Robert", "William", "Thomas", "Daniel", "Paul",
        "Andrew", "Richard", "Charles", "Kevin", "George", "Edward", "Brian",
        "Xavier", "Leon", "Arthur", "Merlin", "Gandalf", "Thor", "Loki",
        "Chris", "Mark", "Jason", "Ryan", "Tyler", "Ethan", "Noah",
        "Liam", "Mason", "Logan", "Lucas", "Oliver", "Henry", "Jack",
        "Owen", "Caleb", "Wyatt", "Hunter", "Carter", "Dylan", "Ian",
        "Nathan", "Aaron", "Adam", "Alan", "Bruce", "Carl", "Dean",
        "Eva", "Frank", "Gary", "Harry", "Isaac", "Jack", "Kyle"
    };
    public readonly string[] GameTypes = { "Vanilla", "Calamity" };
    public readonly string[] GameTypeColors = { "yellow", "magenta" };
    public readonly string[] Classes = { "Melee", "Ranged", "Mage", "Summoner" };
    public readonly string[] ClassColors = { "red", "cyan", "purple", "green" };
    public readonly string[] Contagions = { "Corruption", "Crimson", "Random" };
    public readonly string[] ContagionColors = { "purple", "red", "white" };
    public readonly string RogueClassColor = "yellow";
    public readonly string[] Challenges =
    {
        "Pacifist", "100HP", "First Night Boss", "No Healing", "No Hammers",
        "No Accessories", "No Potions", "No NPCs", "Ironman", "No Building",
        "One Life", "No Hit", "No Armor"
    };
    public readonly string[] ChallengeColors =
    {
        "#00FF00", "#FF0000", "#FF4500",
        "#800080", "#A9A9A9", "#FFD700",
        "#32CD32", "#696969", "#B22222",
        "#8B4513", "#000000", "#FFFFFF",
        "#4169E1"
    };
    public readonly string[] SpecialSeeds =
    {
        "for the worthy", "05162020", "drunk world",
        "the constant", "not the bees!", "crowded",
        "peace candle", "celebrationmk10", "no traps",
        "don't dig up", "get fixed boi"
    };
    public readonly string[] SpecialSeedColors =
    {
        "#00FF41", "#FF69B4", "#9932CC",
        "#FFFF00", "#FFD700", "#FF1493",
        "#00BFFF", "#FF0000", "#808080",
        "#8B008B", "#FF00FF"
    };
    public readonly string[] MapSizes = { "Small", "Medium", "Large" };
    public readonly string[] MapSizeColors = { "#4CAF50", "#2196F3", "#F44336" };
    public string MapSizeDefault => MapSizes[1];
    public readonly string[] Difficultys = { "Standard", "Expert", "Master" };
    public readonly string[] DifficultyColors = { "#4CAF50", "#FF9800", "#F44336" };
    public string DifficultyLevelDefault => Difficultys[2];
    public readonly string[] CalamityDifficultys = { "Revengeance", "Death", "Infernum" };
    public readonly string[] CalamityDifficultyColors = { "#FF6B35", "#E91E63", "#FF0033" };
    public string CalamityDifficultyDefault => CalamityDifficultys[1];

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
    public bool Russian { get; private set; } = false;

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
            UI.Russian = Russian = options.Russian;
            if (options.Count > 1) options.Fast = true;
            if (options.Count > 12)
            {
                if (Russian) UI.PrintError("--count: максимальное значение 12!");
                else UI.PrintError("--count: maximum value is 12!");
                return 1;
            }
            Count = options.Count;
            if (options.MaxAnimationFrames < 55)
            {
                if (Russian) UI.PrintError("Минимальное значение для --maxAnimationFrames равно 55!");
                else UI.PrintError("Minimum value for --maxAnimationFrames is 55!");
                return 1;
            }
            MaxAnimationFrames = options.MaxAnimationFrames;
            Fast = options.Fast;
            if (options.OnlyVanilla && options.OnlyCalamity)
            {
                if (Russian) UI.PrintError("Нельзя использовать --onlyVanilla и --onlyCalamity одновременно!");
                else UI.PrintError("You cannot use --onlyVanilla and --onlyCalamity at the same time!");
                return 1;
            }
            OnlyVanilla = options.OnlyVanilla;
            OnlyCalamity = options.OnlyCalamity;
            UseSeeds = options.UseSeeds;
            UseChallenges = options.UseChallenges;
            UseWorldSize = options.UseWorldSize;
            UseDifficulty = options.UseDifficulty;
            UI.NoAscii = NoAscii = options.NoAscii;
            if (options.NoColor) UI.NoColor();
            if (options.DisabledClasses?.Any() == true)
            {
                var validClasses = Classes.Concat(new[] { "Rogue" }).ToList();
                DisabledClasses = options.DisabledClasses.Distinct().ToList();
                var invalidClasses = DisabledClasses.Where(c => !validClasses.Contains(c, StringComparer.OrdinalIgnoreCase)).ToList();
                if (invalidClasses.Any())
                {
                    if (Russian) UI.PrintError($"Неверные классы: {string.Join(", ", invalidClasses)}");
                    else UI.PrintError($"Invalid classes: {string.Join(", ", invalidClasses)}");
                    return 1;
                }
                if (DisabledClasses.Count == validClasses.Count)
                {
                    if (Russian) UI.PrintError("Нельзя отключить все классы! Должен остаться хотя бы один включённый класс.");
                    else UI.PrintError("Cannot disable all classes! At least one class must remain enabled.");
                    return 1;
                }
            }
            if (options.Version) UI.PrintVersion();
            if (options.ListClasses) UI.PrintListClasses(Classes.Concat(new[] { "Rogue (Calamity only)" }).ToList());
            if (options.Help) UI.PrintHelp();
            return 0;
        },
        errors =>
        {
            if (Russian) UI.PrintError("Параметры введены неверно. Используйте --help для справки.");
            else UI.PrintError("The parameters were entered incorrectly. Use --help for help.");
            return -1;
        });
    }
}
