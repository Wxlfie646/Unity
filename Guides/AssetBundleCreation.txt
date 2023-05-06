# Asset Bundle Creation
## 1. Introduction
### Initial things to note:
  > This may not be as simple as you may have hoped.
  > This requires at least simple knowledge of the Unity Editor. ()
  > Have patience; don't just rush and paste.
Move on to: ==> Begin.
## 2. Begin
### Asset Setup:
To create an asset bundle in Unity, you will, as stated previously, need to have a basic understanding of the Unity Editor. The first step in this process is locating the prefab [Prefab documentation](https://docs.unity3d.com/Manual/Prefabs.html) you would like to pack into your asset bundle and select it in the project folder viewer, whilst the prefab is selected at the bottom of the inspector menu, there will be a section reading "AssetBundle" ![Screenshot of the section at the bottom of the inspector.](https://github.com/Wxlfie646/Unity/blob/main/Images/Inspector-AssetBundle.png) In the large dropdown menu in the middle, there will be a few options: to create an asset bundle to assign this file, select "New..." and name the asset bundle as you wish. Once done and assigned to the asset bundle you have created and named, move on to ==> Creation Setup.
### Creation Setup:
Since this is a multi-step process, I recommend taking one step at a time. First, for asset bundle creation in Unity, one of or possibly the simplest ways to do so is to use a C# (C-Sharp) script. Though the process for creating the script will not be provided in this guide, I have provided one here:
[AssetBundle creation script](https://github.com/Wxlfie646/Unity/blob/main/Scripts/CreateAssetBundles.cs)
Once you have downloaded the script, place it in the assets folder of your Unity project. Move on to ==> Usage.
### Usage:
Once you have imported the script into your project, a new tab should appear on the toolbar on the top row of the editor. within this tab, there will be one or more functions depending on the amount or version of my scripts you have installed on your project. An asset bundle dropdown should be located at the top of this tab. In the asset bundle drop-down menu, there is an option called “Build All Asset Bundles”, this will build all asset bundles in your unity project to the output folder in the directory “Wxlfie646/AssetBundles” If you see don’t see the files here refresh the directory viewer, now the asset bundles that were created should be located in this folder. Move on to: ==> Finish.

## 3. Finish
You're all set! If you encounter any issues with this guide, feel free to let me know.
- **Discord**: Wxlfie#0001


