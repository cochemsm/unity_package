using UnityEngine;
using UnityEditor;

public class ScriptTemplates : MonoBehaviour {
    [MenuItem("Assets/Create/Scripts/Empty Script", false, -10)]
    public static void CreateEmptyScript() {
        string templatePath = "Packages/com.gladys.unity_setup/Editor/ScriptTemplates/EmptyScriptTemplate.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewScript.cs");
    }

    [MenuItem("Assets/Create/Scripts/Singleton", false, -10)]
    public static void CreateSingleton() {
        string templatePath = "Packages/com.gladys.unity_setup/Editor/ScriptTemplates/SingletonTemplate.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewSingleton.cs");
    }

    [MenuItem("Assets/Create/Scripts/Scriptable Object", false, -10)]
    public static void CreateScriptableObject() {
        string templatePath = "Packages/com.gladys.unity_setup/Editor/ScriptTemplates/ScriptableObjectTemplate.txt";
        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewScriptableObject.cs");
    }
}