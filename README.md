# DELTARUNE Chapter 5 - Save Anywhere Mod

![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)
![Mod Type](https://img.shields.io/badge/Mod_Type-UMT_Script-purple)
![Game](https://img.shields.io/badge/Game-DELTARUNE_Chapter_5-red)

A small unofficial **DELTARUNE Chapter 5** quality-of-life mod that lets you press **F5** to open the normal SAVE menu from almost anywhere.

This is meant for those moments where you need to stop playing, but the game has not given you a Save Star nearby.

## What it does

- Adds an **F5 Save Menu hotkey**.
- Opens the game's normal `obj_savemenu` menu.
- Uses the game's existing save system instead of adding a custom one.
- Saves progress, time, flags, items, and other normal save data handled by the game.
- Does **not** include or redistribute any official DELTARUNE files.

## What it does **not** do

This mod does **not** save your exact X/Y position.

Loading still uses the game's valid save/load location instead of forcing the game to reload you in the exact room where F5 was pressed. This is intentional. Saving exact random rooms can cause the game to send you to the DogCheck room or break scripted scenes.

Think of this mod as:

> Save my progress now, but reload me from the last safe/valid save location.

## Requirements

- A legal copy of **DELTARUNE Chapter 5**
- [UndertaleModTool](https://github.com/UnderminersTeam/UndertaleModTool)
- The mod script from this repository:
  - `DeltaruneCH5_SaveAnywhereF5.csx`

## Installation

> **Important:** Back up your `data.win` before doing anything.

1. Download and open **UndertaleModTool**.
2. Open the Chapter 5 `data.win` file in UMT.
3. In UMT, go to:

   ```text
   Scripts -> Run other script...
   ```

4. Select:

   ```text
   DeltaruneCH5_SaveAnywhereF5.csx
   ```

5. Wait for the script to say the patch was applied.
6. Save the modified `data.win` from UMT.
7. Launch DELTARUNE Chapter 5.
8. Press **F5** during normal gameplay to open the SAVE menu.

## Usage

Press:

```text
F5
```

to open the normal SAVE menu.

Recommended use:

- Use it during normal walking/exploration gameplay.
- Use it when you need to quit but there is no Save Star nearby.
- Avoid using it during cutscenes, room transitions, battles, or heavy scripted moments.

## Known limitations

### It does not save exact position

This is expected. The mod does not set `global.currentroom`, because forcing random rooms into the save file can cause DogCheck or unsafe loading behavior.

### It may not work in every gameplay mode

Some sections may use different player/controller logic or block menu opening. If F5 does nothing in a special mode, that is probably the game blocking normal menu behavior there.

### Do not run the patch multiple times

Run the script once on a clean/unpatched `data.win`. Running it repeatedly may append duplicate F5 code.

## Troubleshooting

### F5 does nothing

Make sure:

- You saved the modified `data.win` after running the script.
- You are testing in Chapter 5, not another chapter's data file.
- You are pressing F5 during normal gameplay.
- You are not in a battle, cutscene, room transition, or special scripted mode.

### Loading sends me to DogCheck

Use a clean backup of `data.win` and apply the latest script again.

This mod intentionally avoids setting `global.currentroom`. Older/manual test versions that set `global.currentroom = room;` could make saves load into DogCheck when saving in rooms without Save Stars.

### I want to uninstall the mod

Restore your backed-up `data.win`.

If you installed through Steam, you can also verify the game files to restore the original game data.

## Why this is distributed as a UMT script

This repository does **not** include a modified `data.win` file. Modified `data.win` files contain official game data, so they should not be uploaded or redistributed.

Instead, this mod is distributed as a small UMT script that patches your own legally obtained copy of the game.

## Files

```text
DeltaruneCH5_SaveAnywhereF5.csx  - The UMT patch script
README.md                        - This file
LICENSE                          - MIT license for this mod's original code/docs
```

## Disclaimer

This is an unofficial fan mod.

DELTARUNE, UNDERTALE, and their related characters, music, assets, and code are owned by Toby Fox and their respective rights holders.

This project does not include official DELTARUNE files and is not affiliated with, endorsed by, or sponsored by Toby Fox.

## License

This mod's original script and documentation are released under the **MIT License**.

The MIT License only applies to this repository's original files. It does not apply to DELTARUNE, UndertaleModTool, or any official game files.
