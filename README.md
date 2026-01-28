# Terraria Randomizer

**Terraria Randomizer** generates random character presets for Terraria adventures, eliminating the need to decide on names, classes, seeds, challenges, and other settings. Press Enter/Space to reroll, Esc to exit.

## Features

- Random character names from a curated list
- Class selection: Melee, Ranged, Mage, Summoner (Rogue for Calamity)
- World evil: Corruption, Crimson, or Random
- Special seeds: "for the worthy", "drunk world", "get fixed boi", etc.
- World sizes: Small, Medium, Large
- Difficulties: Standard/Expert/Master (Vanilla) and Revengeance/Death/Infernum (Calamity)
- Challenges: Pacifist, 100HP, No Healing, Ironman, etc.
- Animated rolling effect with customizable speed
- Vanilla or Calamity mod support
- Colorful console UI with ASCII art (disable with flags)

**Version:** 0.3

## Examples

**Generate one random preset (default):**
```
./terraria-random
```

**Calamity Death Mode Rogue:**
```
./terraria-random --onlyCalamity --disableClasses="Melee,Ranged,Mage,Summoner"
```

**Batch of 4 quick Vanilla characters:**
```
./terraria-random --count=4 --fast --onlyVanilla --noAscii
```

## All Options

```
--help                        Show this help
--count=N                     Number of characters (default: 1, max: 12)
--maxAnimationFrames=N        Max animation frames (default: 150, min: 55)
--fast                        Disable roll animation
--onlyVanilla                 Only Vanilla mode
--onlyCalamity                Only Calamity mode
--useSeeds                    Include special seeds
--useChallenges               Include challenges
--useWorldSize                Random world size
--useDifficulty               Random difficulty
--noAscii                     Disable ASCII art
--noColor                     Disable colors
--disableClasses=CLASS,...    Disable classes (Melee,Ranged,Mage,Summoner,Rogue)
--listClasses                 List available classes
-ru                           Russian language
--version                     Show version
```

## Requirements

- .NET runtime
- Windows/Linux/macOS terminal with ANSI support
- [Spectre.Console](https://spectreconsole.net/) NuGet package

## Building

```bash
dotnet build
dotnet publish -c Release -r linux-x64 --self-contained
```

## Author

By.Lonewolf239

***

*Perfect for Terraria players who want instant adventure setups without decision paralysis!*
