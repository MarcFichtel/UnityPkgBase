using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;


[assembly: InternalsVisibleTo("com.razzymcsnazzy.base.Editor.Tests.asmdef")]

public class EditorScript : MonoBehaviour
{
    [MenuItem("RazzyMcSnazzy/Test")]
    public static void Test()
    {
        Debug.Log("Unity Pkg Base Test");
    }

    internal static void TestEditorScriptInternal()
    {
        Debug.Log("Unity Pkg Base Test (Internal, Editor)");
    }
}