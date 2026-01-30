![Terraria Randomizer](https://img.shields.io/badge/Terraria-Randomizer-brightgreen?style=flat&logo=terraria&logoColor=white) 
[![.NET 10](https://img.shields.io/badge/.NET-10.0-blueviolet)](https://dotnet.microsoft.com/download/dotnet/10.0)
[![GitHub stars](https://img.shields.io/github/stars/Lonewolf239/terraria-randomizer)](https://github.com/Lonewolf239/terraria-randomizer)

# Terraria Randomizer

**Terraria Randomizer** instantly generates complete character presets for your next Terraria adventure. No more decision paralysis — get random names, classes, seeds, challenges, and settings with one click. Press **Enter/Space** to reroll, **Esc** to exit.

**Star this repo if it saves you time on character creation!**

**Version:** 0.4 | [.NET 10.0](https://dotnet.microsoft.com/ru-ru/download/dotnet/10.0) | [Download Releases](https://github.com/Lonewolf239/terraria-randomizer/releases)

## Features
- Random character names from curated lists
- Classes: Melee, Ranged, Mage, Summoner (Rogue for Calamity)
- World evil: Corruption, Crimson, or Random
- Special seeds: "for the worthy", "drunk world", "get fixed boi", etc.
- World sizes: Small, Medium, Large
- Difficulties: Standard/Expert/Master + Calamity modes (Revengeance/Death/Infernum)
- Challenges: Pacifist, 100HP, No Healing, Ironman, and more
- Animated rolling with customizable speed
- Calamity mod support
- Colorful console UI with ASCII art (optional)

## Quick Start

**Generate one random preset:**
```bash
./terraria-randomizer
```

**Generate 4 fast Vanilla characters (no animation and ASCII art):**
```bash
./terraria-randomizer --count=4 --fast --onlyVanilla --noAscii
```

**Calamity Death Mode Rogue only:**
```bash
./terraria-randomizer --onlyCalamity --disableClasses="Melee,Ranged,Mage,Summoner"
```

## All Options

| Flag | Description | Default |
|------|-------------|---------|
| `--help` | Show this help | - |
| `--count=N` | Number of characters (1-12) | `1` |
| `--fast` | Skip roll animation | `false` |
| `--onlyVanilla` | Vanilla mode only | `false` |
| `--onlyCalamity` | Calamity mode only | `false` |
| `--useSeeds` | Include special seeds | `true` |
| `--useChallenges` | Include challenges | `true` |
| `--noAscii` | Disable ASCII art | `false` |
| `--noColor` | Disable colors | `false` |
| `--disableClasses="Melee,Ranged"` | Disable specific classes | `none` |
| `--language=en` | Set language | `en` |

*Run `./terraria-randomizer --help` for full list.*

## Installation & Requirements

### Prerequisites
- [.NET 10+ runtime](https://dotnet.microsoft.com/download/dotnet/10.0)
- Terminal with ANSI support (Windows Terminal, Linux, macOS)

### Build from source
```bash
git clone https://github.com/Lonewolf239/terraria-randomizer.git
cd terraria-randomizer
dotnet build
dotnet publish -c Release -r <rid>
```
*Replace `<rid>` with `win-x64`, `linux-x64`, `osx-x64`, etc.*

## Supported Languages
- English (default)
- Run `--listLanguages` for all available

## Example Output
![Demo](https://raw.githubusercontent.com/Lonewolf239/terraria-randomizer/5706ea3/demo.png)

## Credits
**Author:** [Lonewolf239](https://github.com/Lonewolf239)

**Changelogs:** https://github.com/Lonewolf239/terraria-randomizer/releases
