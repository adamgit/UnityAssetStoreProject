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

