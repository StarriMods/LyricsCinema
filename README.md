# Starri Mod - LyricsCinema

This is a Mod for the Game Starri: https://store.steampowered.com/app/1940410/Starri/

It shows the lyrics for a song while it's playing:

![LyricsCinema Demo](./.docs/LyricsCinemaDemo.gif)

The lyrics are displayed in two lines:

1. top - the current line
2. bottom - the upcoming line

When the lyrics are missing accurate timestamps, the lines get shown based on the song length.

# Disclaimer

- **This mod is not affiliated with the game Starri or its developers NEX Team. It is an unofficial mod!**
- This is not intended for cheating or any other malicious purposes. I felt in love with this game and wanted to add some features to it.
- This is experimental! I'm not a software developer. Most of this code is created by ChatGPT and hacked together by me, while trying to figure out how the toolchain works.
- This mod is provided as-is. Use at your own risk!

# Open Issues/Todos

- [ ] check compatibility with different resolutions and fix if needed (I only tested 4k so far)
- [ ] check compatibility with slash mode and fix if needed (I only tested catch mode so far)
- [ ] add more lyrics
- [ ] Add a way to enable/disable the lyrics during the game (by pressing a key)
- [ ] Fine tune timestamps for existing lyrics

# Usage

## Preparation - Install MelonLoader

This mod requires MelonLoader to be installed.

### Install MelonLoader Requirements

See: https://melonwiki.xyz/#/?id=requirements

You'll need all three:

- .NET Framework 4.8 Runtime
- Microsoft Visual C++ 2015-2019
- dotnet 6.0

### Install MelonLoader

1. Install the latest version of MelonLoader. See: https://melonwiki.xyz/#/?id=automated-installation. When installed via Steam, Starri is usually located in `C:\Program Files (x86)\Steam\steamapps\common\Starri`.
2. Run the game once to generate the `MelonLoader` folder in the game's installation directory. (The game will start in offline mode. This is fine. Just exit the game normally.)

### Install the required MelonLoader Plugin

Starri Mods need the MelonLoader Plugin `OnlineMode.dll` to be installed because MelonLoader blocks some essential web requests that are required for Starri to work.

1. Download `OnlineMode.dll`
2. Copy `OnlineMode.dll` to the `Plugins` folder in the Starri installation directory: `C:\Program Files (x86)\Steam\steamapps\common\Starri\Plugins`

### Install the Mod

1. Download `LyricsCinema.dll`
2. Copy `LyricsCinema.dll` to the `Mod` folder in the Starri installation directory: `C:\Program Files (x86)\Steam\steamapps\common\Starri\Mod`
3. Start the game. If lyrics are found, they will be shown

### Configuration Files

The placement and size of the two lines can be adjusted in the configuration file: `C:\Program Files (x86)\Steam\steamapps\common\Starri\UserData\LyricsCinema.cfg`

# Development

## Contributing

Feel free to contribute to this project. If you have any questions, feel free to open an issue.

## Environment Variable

You need to set an environment variable to the path of the Starri installation directory before building the project.:

````powershell
[System.Environment]::SetEnvironmentVariable('STARRI_NET6_DIRECTORY', 'C:\Program Files (x86)\Steam\steamapps\common\Starri', 'User')
````

## Debug log

Compile with debug configuration to enable an overwhelming amount of (mostly repetitive) debug logs.

## Adding new lyrics

The mod uses a modified version of LCR style lyrics.

Note: the `ms` value is currently ignored but is required to have.

1. copy a song file like: `songs\BrainPower.cs`
2. replace the name `BrainPower` with the id of the song. The `id` can be found in the assets or in the log output of this mod(it logs the id when a song is played)
3. Find the LCR lyrics or make them yourself at sites like: https://www.megalobiz.com/lrc/maker
    4.
4. adjust the style according to the existing songs: `("mm:ss.ms", "Text"),`
5. add `<SongName>.RegisterLyrics();` in `OnLateInitializeMelon`