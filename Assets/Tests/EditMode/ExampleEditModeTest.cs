using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEngine;

public class ExampleEditModeTest
{
    private static uint[] _untilNumbers = new uint[] {100, 100_000, 100_000_000};
    
    [Test, Performance]
    public void _01SimpleGetSumTest([ValueSource(nameof(_untilNumbers))] uint until)
    {
        Measure.Method(() =>
        {
            GetSum(until);
        }).Run();
    }

    [Test, Performance]
    public void _02FastGetSumTest([ValueSource(nameof(_untilNumbers))] uint until)
    {
        Measure.Method(() =>
        {
            FastGetSum(until);
        }).Run();
    }

    private void GetSum(uint until)
    {
        uint sum = 0;
        for (uint i = 1; i <= until; i++)
        {
            sum += i;
        }
        Debug.Log($"GetSum({until}): {sum}");
    }

    private void FastGetSum(uint until)
    {
        uint sum = 0;
        if (until % 2 == 0)
        {
            sum = (1 + until) * (until / 2);
            Debug.Log($"FastGetSum({until}): {sum}");
            return;
        }

        sum = (1 + until) * (until / 2) + (until / 2 + 1);
        Debug.Log($"FastGetSum({until}): {sum}");
    }
}
