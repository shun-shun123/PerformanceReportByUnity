using UnityEngine;
using UnityEngine.TestTools;

namespace Benchmark.Prebuild
{
    public class ScriptPerformancePrebuildStep : MonoBehaviour, IPrebuildSetup
    {
        public void Setup()
        {
            Debug.Log("IPrebuildSetup.Setup is called.");
        }
    }
}