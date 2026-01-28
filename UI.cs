using System;
using System.Collections.Generic;
using System.Linq;
using Spectre.Console;

namespace TerrariaRandomizer;

public static class UI
{
    public static bool NoAscii = false;
    public static bool Russian = false;

    public static void PrintTitle()
    {
        string title = @"       [#228B22]+%*[/]            [lime]______[/]
   [#228B22]**+*=+=+*#[/]        [lime]/\__  _\                                     __[/]
   [#228B22]*#**+++*+#+%[/]      [lime]\/_/\ \/    __   _ __   _ __    __     _ __ /\_\     __[/]
  [#228B22]+***+*+++*%*#[/]         [lime]\ \ \  /'__`\/\`'__\/\`'__\/'__`\  /\`'__\/\ \  /'__`\[/]
  [#228B22]%#*#**#***[/][#1A3A1A]##%[/]          [lime]\ \ \/\  __/\ \ \/ \ \ \//\ \L\.\_\ \ \/ \ \ \/\ \L\.\_[/]
   [#228B22]####[/][#1A3A1A]##%###%[/]            [lime]\ \_\ \____\\ \_\  \ \_\\ \__/.\_\\ \_\  \ \_\ \__/.\_\[/]
      [#1A3A1A]@%#[/][#5A2A2A]+[/]                 [lime]\/_/\/____/ \/_/   \/_/ \/__/\/_/ \/_/   \/_/\/__/\/_/[/]
      [#3D1A1A]=#[/][#5A2A2A]*=[/]
[#228B22]%*+*%[/] [#3D1A1A].#[/][#5A2A2A]*+[/]                 [lime]____                         __[/]
 [#228B22]:[/][#1A3D1A]##[/][#3D1A1A]%+**[/][#5A2A2A]*=[/]                [lime]/\  _`\     [yellow]By.Lonewolf239[/]   /\ \[/]                [grey]v" + Program.Version + @"[/]
      [#3D1A1A]:#[/][#5A2A2A]*=[/]  [#1A3D1A]#[/][#228B22]++=%[/]         [lime]\ \ \L\ \     __      ___    \_\ \    ___     ___ ___[/]
      [#3D1A1A]:#[/][#5A2A2A]+=#+[/][#1A3D1A]*##[/][#228B22]#[/]           [lime]\ \ ,  /   /'__`\  /' _ `\  /'_` \  / __`\ /' __` __`\[/]
      [#3D1A1A].*[/][#5A2A2A]*=[/]                  [lime]\ \ \\ \ /\ \L\.\_/\ \/\ \/\ \L\ \/\ \L\ \/\ \/\ \/\ \[/]
     [#3D1A1A].%#[/][#5A2A2A]++#[/]                  [lime]\ \_\ \_\ \__/.\_\ \_\ \_\ \___,_\ \____/\ \_\ \_\ \_\[/]
   [#3D1A1A].#+#%[/][#5A2A2A]#=%++[/]                 [lime]\/_/\/ /\/__/\/_/\/_/\/_/\/__,_ /\/___/  \/_/\/_/\/_/[/]";
        if (NoAscii)
        {
            PrintTitleNoAscii();
            return;
        }
        string[] lines = title.Split('\n');
        foreach (string line in lines) AnsiConsole.MarkupLine(line);
        Console.WriteLine('\n');
    }

    private static void PrintTitleNoAscii()
    {
        AnsiConsole.MarkupLine("[lime]Terraria Random[/]\n[yellow]By.Lonewolf239[/] [grey]v" + Program.Version + "[/]");
        Console.WriteLine('\n');
    }

    public static void PrintVersion()
    {
        Console.CursorVisible = true;
        PrintTitleNoAscii();
        Environment.Exit(0);
    }

    public static void Clear() => AnsiConsole.Clear();

    public static void NoColor() => AnsiConsole.Profile.Capabilities.ColorSystem = ColorSystem.NoColors;

    public static void PrintError(string message)
    {
        Console.CursorVisible = true;
        if (Russian) AnsiConsole.MarkupLine($"[red]Ошибка:[/] {message}");
        else AnsiConsole.MarkupLine($"[red]Error:[/] {message}");
        Environment.Exit(1);
    }

    public static void PrintRule()
    {
        string title = Russian ? "Enter/Space - пересоздать, Esc - выход" : "Enter/Space - recreate, Esc - exit";
        var rule = new Rule("[silver]" + title + "[/]");
        rule.Style = Style.Parse("grey");
        AnsiConsole.Write(rule);
    }

    public static void PrintHelp()
    {
        Console.CursorVisible = true;
        PrintTitle();
        if (Russian)
        {
            AnsiConsole.MarkupLine("Параметры:");
            AnsiConsole.MarkupLine("  [yellow]--help[/]                       [grey]Показать эту справку[/]");
            AnsiConsole.MarkupLine("  [yellow]--count=N[/]                    [grey]Количество персонажей для генерации (по умолчанию: 1, макс: 12)[/]");
            AnsiConsole.MarkupLine("  [yellow]--maxAnimationFrames=N[/]       [grey]Макс. кадров анимации (по умолчанию: 150, мин: 55)[/]");
            AnsiConsole.MarkupLine("  [yellow]--fast[/]                       [grey]Отключить анимацию ролла[/]");
            AnsiConsole.MarkupLine("  [yellow]--onlyVanilla[/]                [grey]Только режим Vanilla[/]");
            AnsiConsole.MarkupLine("  [yellow]--onlyCalamity[/]               [grey]Только режим Calamity[/]");
            AnsiConsole.MarkupLine("  [yellow]--useSeeds[/]                   [grey]Использовать специальные сиды[/]");
            AnsiConsole.MarkupLine("  [yellow]--useChallenges[/]              [grey]Использовать испытания[/]");
            AnsiConsole.MarkupLine("  [yellow]--useWorldSize[/]               [grey]Использовать размер мира[/]");
            AnsiConsole.MarkupLine("  [yellow]--useDifficulty[/]              [grey]Использовать сложность[/]");
            AnsiConsole.MarkupLine("  [yellow]--noAscii[/]                    [grey]Отключить ASCII-арт[/]");
            AnsiConsole.MarkupLine("  [yellow]--noColor[/]                    [grey]Отключить цвета[/]");
            AnsiConsole.MarkupLine("  [yellow]--disableClasses=CLASS,...[/]   [grey]Отключить определённые классы[/]");
            AnsiConsole.MarkupLine("  [yellow]--listClasses[/]                [grey]Список доступных классов[/]");
            AnsiConsole.MarkupLine("  [yellow]--ru[/]                         [grey]Включить русский язык[/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[grey]Примеры:[/]");
            AnsiConsole.MarkupLine("  [green]terraria-random[/] [yellow]-c=3 -f --noAscii --noColor[/]");
            AnsiConsole.MarkupLine("  [green]terraria-random[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]");
        }
        else
        {
            AnsiConsole.MarkupLine("Options:");
            AnsiConsole.MarkupLine("  [yellow]--help[/]                       [grey]Show this help[/]");
            AnsiConsole.MarkupLine("  [yellow]--count=N[/]                    [grey]Number of characters to generate (default: 1, max: 12)[/]");
            AnsiConsole.MarkupLine("  [yellow]--maxAnimationFrames=N[/]       [grey]Max animation frames (default: 150, min: 55)[/]");
            AnsiConsole.MarkupLine("  [yellow]--fast[/]                       [grey]Disable roll animation[/]");
            AnsiConsole.MarkupLine("  [yellow]--onlyVanilla[/]                [grey]Only Vanilla mode[/]");
            AnsiConsole.MarkupLine("  [yellow]--onlyCalamity[/]               [grey]Only Calamity mode[/]");
            AnsiConsole.MarkupLine("  [yellow]--useSeeds[/]                   [grey]Use special seeds[/]");
            AnsiConsole.MarkupLine("  [yellow]--useChallenges[/]              [grey]Use challenges[/]");
            AnsiConsole.MarkupLine("  [yellow]--useWorldSize[/]               [grey]Use world size[/]");
            AnsiConsole.MarkupLine("  [yellow]--useDifficulty[/]              [grey]Use difficulty[/]");
            AnsiConsole.MarkupLine("  [yellow]--noAscii[/]                    [grey]Disable ASCII art[/]");
            AnsiConsole.MarkupLine("  [yellow]--noColor[/]                    [grey]Disable colors[/]");
            AnsiConsole.MarkupLine("  [yellow]--disableClasses=CLASS,...[/]   [grey]Disable specific classes[/]");
            AnsiConsole.MarkupLine("  [yellow]--listClasses[/]                [grey]List available classes[/]");
            AnsiConsole.MarkupLine("  [yellow]--ru[/]                         [grey]Enable russian language[/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[grey]Examples:[/]");
            AnsiConsole.MarkupLine("  [green]terraria-random[/] [yellow]-c=3 -f --noAscii --noColor[/]");
            AnsiConsole.MarkupLine("  [green]terraria-random[/] [yellow]--onlyCalamity --useChallenges --useSeeds[/]");
        }
        Console.WriteLine();
        Environment.Exit(0);
    }

    public static void PrintListClasses(List<string> classes)
    {
        Console.CursorVisible = true;
        PrintTitleNoAscii();
        if (Russian)
        {
            AnsiConsole.MarkupLine("[grey]Доступные классы:[/]");
            foreach (var item in classes) AnsiConsole.MarkupLine("  [green]" + item + "[/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[grey]Available classes:[/]");
            foreach (var item in classes) AnsiConsole.MarkupLine("  [green]" + item + "[/]");
        }
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
        string T(string ruText, string enText) => Russian ? ruText : enText;
        string gameTypeColor = GetColor(parameters.GameTypeColors, parameters.GameTypes, generationResult.GameType);
        string classColor = generationResult.CharacterClass == "Rogue"
            ? parameters.RogueClassColor
            : GetColor(parameters.ClassColors, parameters.Classes, generationResult.CharacterClass);
        string evilColor = GetColor(parameters.ContagionColors, parameters.Contagions, generationResult.Evil);
        string challengeColor = GetColor(parameters.ChallengeColors, parameters.Challenges, generationResult.Challenge);
        string seedColor = GetColor(parameters.SpecialSeedColors, parameters.SpecialSeeds, generationResult.Seed);
        string mapSizeColor = GetColor(parameters.MapSizeColors, parameters.MapSizes, generationResult.MapSize);
        string difficultyColor = GetColor(parameters.DifficultyColors, parameters.Difficultys, generationResult.Difficulty);
        string calamityDifficultyColor = GetColor(parameters.CalamityDifficultyColors, parameters.CalamityDifficultys, generationResult.CalamityDifficulty);
        string worldName = $"{generationResult.Name}'s world";
        string difficulty = generationResult.GameType == "Vanilla"
            ? Colorize(generationResult.Difficulty, difficultyColor)
            : $"{Colorize(generationResult.CalamityDifficulty, calamityDifficultyColor)}+{Colorize(generationResult.Difficulty, difficultyColor)}";
        var rows = new List<(string label, string value)>
        {
            (T("Версия игры", "Game Version"), Colorize(generationResult.GameType, gameTypeColor)),
            (T("Имя", "Name"), Colorize(generationResult.Name, "white")),
            (T("Имя мира", "World Name"), Colorize(worldName, "gold1")),
            (T("Класс", "Class"), Colorize(generationResult.CharacterClass, classColor)),
            (T("Зло мира", "World Evil"), Colorize(generationResult.Evil, evilColor)),
        };
        if (parameters.UseChallenges) rows.Add((T("Испытание", "Challenge"), Colorize(generationResult.Challenge, challengeColor)));
        if (parameters.UseSeeds) rows.Add((T("Сид", "Seed"), Colorize(generationResult.Seed, seedColor)));
        rows.Add((T("Размер карты", "Map Size"), Colorize(generationResult.MapSize, mapSizeColor)));
        rows.Add((T("Сложность", "Difficulty"), difficulty));
        PrintAligned(rows);
    }
}
