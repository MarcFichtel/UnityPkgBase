using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("com.razzymcsnazzy.base.Tests.asmdef")]

public class RuntimeScript : MonoBehaviour
{
    internal static void TestRuntimeScriptInternal()
    {
        Debug.Log("Unity Pkg Base Test (Internal, Runtime)");
    }
}
