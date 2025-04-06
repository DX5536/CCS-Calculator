using UnityEngine;

[CreateAssetMenu(fileName = "Price", menuName = "ScriptableObject/PriceData/Spiral", order = 3)]
public class SpiralPriceFactor_SO: ScriptableObject
{
    [SerializeField]
    private float price_A4_PrintedHere;

    public float Price_A4_PrintedHere
    {
        get
        {
            return price_A4_PrintedHere;
        }
    }

    [SerializeField]
    private float price_8mm_9mm;

    public float Price_8mm_9mm
    {
        get
        {
            return price_8mm_9mm;
        }
    }

    [SerializeField]
    private float price_11mm_12mm;

    public float Price_11mm_12mm
    {
        get
        {
            return price_11mm_12mm;
        }
    }

    [SerializeField]
    private float price_14mm_16mm;

    public float Price_14mm_16mm
    {
        get
        {
            return price_14mm_16mm;
        }
    }

    [SerializeField]
    private float price_19mm_22mm_25mm;

    public float Price_19mm_22mm_25mm
    {
        get
        {
            return price_19mm_22mm_25mm;
        }
    }

    [SerializeField]
    private float price_28mm_32mm;

    public float Price_28mm_32mm
    {
        get
        {
            return price_28mm_32mm;
        }
    }
}
