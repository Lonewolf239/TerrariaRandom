using TerrariaRandomizer.Configuration;
using TerrariaRandomizer.Data;

namespace TerrariaRandomizer;

public static class Generator
{
    public static async Task Generate(Parameters parameters, Random rand)
    {
        int y = parameters.NoAscii ? 5 : 18;
        Console.Write($"\x1b[{y};0H");
        for (int i = 0; i < parameters.Count; i++)
        {
            UI.PrintResults(parameters, await GenerateCharacter(parameters, rand));
            Console.WriteLine();
        }
    }

    public static async Task<GenerationResult> GenerateCharacter(Parameters parameters, Random rand)
    {
        string name = Random(rand, Constants.Names);
        (string gameType, List<string> validClasses) = GetGameTypeAndValidClasses(parameters, rand);
        if (!validClasses.Any())
        {
            for (int i = 0; i < 64; i++)
            {
                (gameType, validClasses) = GetGameTypeAndValidClasses(parameters, rand);
                if (validClasses.Any()) break;
            }
            if (!validClasses.Any()) UI.PrintError("GenerateCharacter.ValidClasses.Error".Localize(parameters.Language));
        }
        string characterClass = validClasses[rand.Next(validClasses.Count)];
        string evil = Random(rand, Constants.Contagions);
        string challenge = Random(rand, Constants.Challenges);
        string seed = Random(rand, Constants.SpecialSeeds);
        string mapSize = parameters.UseWorldSize ? Random(rand, Constants.MapSizes) : Constants.MapSizeDefault;
        string difficulty = parameters.UseDifficulty ? Random(rand, Constants.Difficultys) : Constants.DifficultyLevelDefault;
        string calamityDifficulty = parameters.UseDifficulty ? Random(rand, Constants.CalamityDifficultys) : Constants.CalamityDifficultyDefault;
        return new GenerationResult
        {
            GameType = gameType,
            Name = name,
            CharacterClass = characterClass,
            Evil = evil,
            Challenge = challenge,
            Seed = seed,
            MapSize = mapSize,
            Difficulty = difficulty,
            CalamityDifficulty = calamityDifficulty
        };
    }

    private static (string, List<string>) GetGameTypeAndValidClasses(Parameters parameters, Random rand)
    {
        string gameType = parameters.OnlyVanilla ? "Vanilla" : parameters.OnlyCalamity ? "Calamity" : Random(rand, Constants.GameTypes);
        var availableClasses = Constants.Classes.ToList();
        if (gameType != "Calamity") availableClasses = Constants.Classes.Take(4).ToList();
        var validClasses = availableClasses.Where(c => !parameters.DisabledClasses.Contains(c, StringComparer.OrdinalIgnoreCase)).ToList();
        return (gameType, validClasses);
    }

    private static string Random(Random rand, string[] array) => array[rand.Next(array.Length)];
}
