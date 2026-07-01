// DELTARUNE Chapter 5 - Save Anywhere F5
// Unofficial fan mod by sonic Fan Tech
//
// This script does NOT include any official DELTARUNE files.
// It patches the user's own data.win in UndertaleModTool.
//
// Hotkey:
// F5 = open the normal Save Menu anywhere.
// Safer version: does NOT set global.currentroom,
// so loading should return to the last valid save location.

using UndertaleModLib.Compiler;

EnsureDataLoaded();

ScriptMessage(
    "DELTARUNE Chapter 5 - Save Anywhere F5\n\n" +
    "This will append an F5 Save Menu hotkey to obj_mainchara Step.\n\n" +
    "IMPORTANT:\n" +
    "- Make a backup of data.win first.\n" +
    "- Run this only once on a clean/unpatched data.win.\n" +
    "- This does not include official game files."
);

var target = Data.Code.ByName("gml_Object_obj_mainchara_Step_0");

if (target == null)
{
    ScriptError(
        "Could not find gml_Object_obj_mainchara_Step_0.\n\n" +
        "This script may be for the wrong DELTARUNE version/chapter.",
        "Patch failed"
    );
    return;
}

string patchCode = @"

// --- Save Anywhere F5 Mod START ---
// Press F5 to open the normal SAVE menu.
// This does NOT set global.currentroom, because random rooms can DogCheck on load.
if (keyboard_check_pressed(vk_f5))
{
    if (global.interact == 0 && !instance_exists(obj_savemenu) && !instance_exists(obj_dialoguer))
    {
        global.msc = 0;
        global.typer = 5;
        
        if (global.darkzone == 1)
            global.typer = 6;
        
        global.fc = 0;
        global.fe = 0;
        global.interact = 1;
        
        onebuffer = 2;
        twobuffer = 2;
        threebuffer = 2;
        
        instance_create(0, 0, obj_savemenu);
    }
}
// --- Save Anywhere F5 Mod END ---
";

CodeImportGroup importGroup = new(Data)
{
    MainThreadAction = MainThreadAction
};

importGroup.QueueAppend(target, patchCode);
importGroup.Import();

ChangeSelection(target);

ScriptMessage(
    "Save Anywhere F5 patch applied!\n\n" +
    "Now save the modified data.win from UMT.\n\n" +
    "Use F5 during normal walking gameplay.\n" +
    "Avoid battles, cutscenes, transitions, and scripted scenes."
);