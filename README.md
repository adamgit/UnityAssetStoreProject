# UnityAssetStoreProject

This is a well-designed base for creating a new Unity project for re-usable code/projects, especially for shipping to AssetStore

## CRITICAL! For making DLL-export work...

After cloning this repository you MUST generate a symlink to the folder where your preferred copy of Unity is installed. This is required because Unity doesn't currently provide a well-packaged SDK, so for us to build against Unity libraries/DLLs we need a reliable, machine-independent, way of finding the installed DLLs on your system.

Windows10:

1. Open Command Prompt (Windows bug: cannot be done with PowerShell/Terminal/etc)
2. cd [the folder where you cloned this project to]
3. cd development
4. mklink /J UnitySymlink [your UnityEditor DLLs folder, this ends in "\Editor\Data\Managed\"]

MacOSX / Linux:

1. cd [the folder where you cloned this project to]
2. cd development
3. ln -s [your UnityEditor DLLs folder, ends in "/Editor/Data/Managed/"] UnitySymlink

# Usage instructions

I'll write longer instructions soon :) but TL;DR:

1. Put all your source code in "source-as-package" - that folder is a standard Unity local-package / package-from-disk
2. Put all your UnityProjects e.g. "TestProject", e.g. "AssetStoreUploadProject", e.g. "Dev-2019", e.g. "Dev-2020", e.g. "Test-LatestUnityAlpha" ... in the "runnable-projects" folder
3. ...each UnityProject use PackageManager > Add Package from Disk > select the pacakge in "source-as-package"
4. FIX THE UNITY BUG where they stupidly put an absolute reference: edit package.json in your project's Packages folder and change the "file:C:\Unity\is\stupid" into "file:..\..\etc"

Now use as normal, develop as normal. To build a DLL open the solution in "buildable-DLLs" - it is preconfigured to be compatible with Unity, generating a Runtime DLL and an Editor DLL both with the same name (required by Unity) in different subfolders, it outputs them to "exportedDLLs".

When you add new source files to the project you probably need to re-add them in the DLL-making  .sln but that's a simple: open IDE for Solution, select the source-folder, and do "Add Existing files" and then select everyning in that folder *but make sure you add them as Links not as Copied files*