using System;
using UnityEngine;

public class EventManager: MonoBehaviour
{
    //Event for calculating the price of Spiralbinding
    public static event Action onSpiralCalculation;
    public static void SpiralCalculation()
    {
        if (onSpiralCalculation != null)
        {
            onSpiralCalculation();
        }
    }

    //Event for calculating the price of Softcover
    public static event Action onSoftcoverCalculation;
    public static void SoftcoverCalculation()
    {
        if (onSoftcoverCalculation != null)
        {
            onSoftcoverCalculation();
        }
    }

    //Event for calculating the price of Hardcover
    public static event Action onHardcoverCalculation;
    public static void HardcoverCalculation()
    {
        if (onHardcoverCalculation != null)
        {
            onHardcoverCalculation();
        }
    }
}
