using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public class AssetBundleCreator
{
    // Sets menu item to call bundle creation method below.
    [MenuItem("Wxlfie646/Build All Asset Bundles")]
    private static void BuildAssetBundles()
    {
        Debug.Log("[Function Call] Called : AssetBundleCreator.BuildAssetBundles()");

        // - Data store
        string assetbundlepath = Application.dataPath + "/Wxlfie646/AssetBundles";

        // - Asset bundle creation
        try
        {
            // - Create output folder
            if (!Directory.Exists(assetbundlepath))
            {
                Directory.CreateDirectory(assetbundlepath);
            }

            // - Builds asset bundles (all)
            BuildPipeline.BuildAssetBundles(assetbundlepath, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
            Debug.Log("[Function Call] Sucsess! : UnityEditor.BuildPipeline.BuildAssetBundles()");
        }
        catch (Exception ex) { Debug.LogWarning("[Exception]: " + ex.Message + " in " + ex.Source + " Stack: " + ex.StackTrace); }
    }
}
 