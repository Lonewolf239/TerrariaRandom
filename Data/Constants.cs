namespace TerrariaRandomizer.Data;

public static class Constants
{
    public const string Version = "0.5.2";
    public static readonly string AsciiArt = @"       [#228B22]+%*[/]            [lime]______[/]
   [#228B22]**+*=+=+*#[/]        [lime]/\__  _\                                     __[/]
   [#228B22]*#**+++*+#+%[/]      [lime]\/_/\ \/    __   _ __   _ __    __     _ __ /\_\     __[/]
  [#228B22]+***+*+++*%*#[/]         [lime]\ \ \  /'__`\/\`'__\/\`'__\/'__`\  /\`'__\/\ \  /'__`\[/]
  [#228B22]%#*#**#***[/][#1A3A1A]##%[/]          [lime]\ \ \/\  __/\ \ \/ \ \ \//\ \L\.\_\ \ \/ \ \ \/\ \L\.\_[/]
   [#228B22]####[/][#1A3A1A]##%###%[/]            [lime]\ \_\ \____\\ \_\  \ \_\\ \__/.\_\\ \_\  \ \_\ \__/.\_\[/]
      [#1A3A1A]@%#[/][#5A2A2A]+[/]                 [lime]\/_/\/____/ \/_/   \/_/ \/__/\/_/ \/_/   \/_/\/__/\/_/[/]
      [#3D1A1A]=#[/][#5A2A2A]*=[/]
[#228B22]%*+*%[/] [#3D1A1A].#[/][#5A2A2A]*+[/]                 [lime]____                         __[/]
 [#228B22]:[/][#1A3D1A]##[/][#3D1A1A]%+**[/][#5A2A2A]*=[/]                [lime]/\  _`\     [yellow]By.Lonewolf239[/]   /\ \[/]               [grey]v" + Version + @"[/]
      [#3D1A1A]:#[/][#5A2A2A]*=[/]  [#1A3D1A]#[/][#228B22]++=%[/]         [lime]\ \ \L\ \     __      ___    \_\ \    ___     ___ ___[/]
      [#3D1A1A]:#[/][#5A2A2A]+=#+[/][#1A3D1A]*##[/][#228B22]#[/]           [lime]\ \ ,  /   /'__`\  /' _ `\  /'_` \  / __`\ /' __` __`\[/]
      [#3D1A1A].*[/][#5A2A2A]*=[/]                  [lime]\ \ \\ \ /\ \L\.\_/\ \/\ \/\ \L\ \/\ \L\ \/\ \/\ \/\ \[/]
     [#3D1A1A].%#[/][#5A2A2A]++#[/]                  [lime]\ \_\ \_\ \__/.\_\ \_\ \_\ \___,_\ \____/\ \_\ \_\ \_\[/]
   [#3D1A1A].#+#%[/][#5A2A2A]#=%++[/]                 [lime]\/_/\/ /\/__/\/_/\/_/\/_/\/__,_ /\/___/  \/_/\/_/\/_/[/]";
    public static readonly string[] Names =
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
    public static readonly string[] GameTypes = { "Vanilla", "Calamity" };
    public static readonly string[] GameTypeColors = { "yellow", "magenta" };
    public static readonly string[] Classes = { "Melee", "Ranged", "Mage", "Summoner", "True Melee", "Rogue" };
    public static readonly string[] ClassColors = { "#FF0000", "#00FFFF", "#800080", "#008000", "#B22222", "#FFFF00" };
    public static readonly string[] Contagions = { "Corruption", "Crimson", "Random" };
    public static readonly string[] ContagionColors = { "purple", "red", "white" };
    public static readonly string[] Challenges =
    {
        "Pacifist", "100HP", "First Night Boss", "No Healing", "No Hammers",
        "No Accessories", "No Potions", "No NPCs", "Ironman", "No Building",
        "One Life", "No Hit", "No Armor"
    };
    public static readonly string[] ChallengeColors =
    {
        "#00FF00", "#FF0000", "#FF4500",
        "#800080", "#A9A9A9", "#FFD700",
        "#32CD32", "#696969", "#B22222",
        "#8B4513", "#000000", "#FFFFFF",
        "#4169E1"
    };
    public static readonly string[] SpecialSeeds =
    {
        "for the worthy", "05162020", "drunk world",
        "the constant", "not the bees!", "crowded",
        "peace candle", "celebrationmk10", "no traps",
        "don't dig up", "get fixed boi"
    };
    public static readonly string[] SpecialSeedColors =
    {
        "#00FF41", "#FF69B4", "#9932CC",
        "#FFFF00", "#FFD700", "#FF1493",
        "#00BFFF", "#FF0000", "#808080",
        "#8B008B", "#FF00FF"
    };
    public static readonly string[] MapSizes = { "Small", "Medium", "Large" };
    public static readonly string[] MapSizeColors = { "#4CAF50", "#2196F3", "#F44336" };
    public static readonly string[] Difficultys = { "Standard", "Expert", "Master" };
    public static readonly string[] DifficultyColors = { "#4CAF50", "#FF9800", "#F44336" };
    public static readonly string[] CalamityDifficultys = { "Revengeance", "Death", "Infernum" };
    public static readonly string[] CalamityDifficultyColors = { "#FF6B35", "#E91E63", "#FF0033" };
    public static string MapSizeDefault => MapSizes[1];
    public static string DifficultyLevelDefault => Difficultys[2];
    public static string CalamityDifficultyDefault => CalamityDifficultys[1];
}
