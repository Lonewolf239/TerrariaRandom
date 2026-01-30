using System.Collections.Generic;
using CommandLine;

namespace TerrariaRandomizer.Configuration;

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

    [Option("language", Default = "en")]
    public string Language { get; set; }

    [Option("listLanguages")]
    public bool ListLanguages { get; set; }
}
