using UnityEngine;
using UnityEditor;

public class BuildTools
{
    [MenuItem("Build/Build APK")]
    public static void BuildApk()
    {
        BuildPlayerOptions opt = new BuildPlayerOptions();
        opt.scenes = new string[] { "Assets/Scenes/SampleScene.unity"};
        opt.locationPathName = Application.dataPath + "/../Bin/test.apk";
        //Debug.Log(Application.dataPath + "/../Bin/test.apk");
        opt.target = BuildTarget.Android;
        opt.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(opt);

        Debug.Log("Build App Done!");
    }
}
