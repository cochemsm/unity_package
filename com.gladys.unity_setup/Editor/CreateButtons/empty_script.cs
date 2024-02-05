using UnityEngine;
using UnityEditor;
using System.IO;
using System;
using System.Reflection;

public class empty_script : MonoBehaviour {
    static void EmptyScript() {
        Type projectWindowUtilType = typeof(ProjectWindowUtil);
        MethodInfo getActiveFolderPath = projectWindowUtilType.GetMethod("GetActiveFolderPath", BindingFlags.Static | BindingFlags.NonPublic);
        object obj = getActiveFolderPath.Invoke(null, new object[0]);
        string pathToCurrentFolder = obj.ToString();
        Debug.Log(pathToCurrentFolder);

        string name = "newEmpty";
        string copyPath = pathToCurrentFolder + "/" + name + ".cs";
        Debug.Log("Creating Classfile: " + copyPath);

        if (File.Exists(copyPath) == false) { // do not overwrite
            using (StreamWriter outfile =
                new StreamWriter(copyPath)) {
                outfile.WriteLine("using UnityEngine;");
                outfile.WriteLine("using System.Collections;");
                outfile.WriteLine("");
                outfile.WriteLine("public class newEmpty : MonoBehaviour {");
                outfile.WriteLine(" ");
                outfile.WriteLine("}");
            }//File written
        }

        string fileName = copyPath;
        string fullPath = Path.GetFullPath(fileName);
        print(fullPath);

        FileSystemWatcher watcher = new FileSystemWatcher(fullPath);
        watcher.Renamed += OnRenamed;

        AssetDatabase.Refresh();
    }

    private static void OnRenamed(object sender, RenamedEventArgs e) {
        print($"Renamed:");
        print($"    Old: {e.OldFullPath}");
        print($"    New: {e.FullPath}");
    }
}