using UnityEngine;

[CreateAssetMenu(fileName = "Price", menuName = "ScriptableObject/PriceData/Softcover", order = 2)]
public class SoftcoverPriceFactor_SO: ScriptableObject
{
    [Header("READONLY: Which front type for softcover? Transparent, Pappe or foil printed Pappe")]
    [SerializeField]
    private string softcoverType;

    [Header("Price")]
    [SerializeField]
    private float softcover_A4_PrintedHere;

    public float Softcover_A4_PrintedHere
    {
        get
        {
            return softcover_A4_PrintedHere;
        }
    }

    [SerializeField]
    private float softcover_A4_NotPrintedHere;

    public float Softcover_A4_NotPrintedHere
    {
        get
        {
            return softcover_A4_NotPrintedHere;
        }
    }

    [SerializeField]
    private float softcover_A4_Quer;

    public float Softcover_A4_Quer
    {
        get
        {
            return softcover_A4_Quer;
        }
    }

    [SerializeField]
    private float softcover_A5;

    public float Softcover_A5
    {
        get
        {
            return softcover_A5;
        }
    }

    [SerializeField]
    private float softcover_A3_PrintedHere;

    public float Softcover_A3_PrintedHere
    {
        get
        {
            return softcover_A3_PrintedHere;
        }
    }

    [SerializeField]
    private float softcover_A3_NotPrintedHere;

    public float Softcover_A3_NotPrintedHere
    {
        get
        {
            return softcover_A3_NotPrintedHere;
        }
    }

}
