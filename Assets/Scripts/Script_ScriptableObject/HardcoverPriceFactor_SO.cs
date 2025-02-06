using UnityEngine;

[CreateAssetMenu(fileName = "Price", menuName = "ScriptableObject/PriceData/Hardcover", order = 1)]
public class HardcoverPriceFactor_SO: ScriptableObject
{
    [Header("READONLY: Which hardcover type? Europa or Classic")]
    [SerializeField]
    private string hardcoverType;

    [Header("READONLY: What is the hardcover size? A5, A4, A4 Quer, A3 or 210x210 Square")]
    [SerializeField]
    private string hardcoverSize;
    public string HardcoverSize
    {
        get
        {
            return hardcoverSize;
        }
    }


    [Header("If value is -1, it means this option doesn't exist")]
    [SerializeField]
    private float price_5mm;

    public float Price_5mm
    {
        get
        {
            return price_5mm;
        }

    }

    [SerializeField]
    private float price_7mm;

    public float Price_7mm
    {
        get
        {
            return price_7mm;
        }

    }

    [SerializeField]
    private float price_10mm;

    public float Price_10mm
    {
        get
        {
            return price_10mm;
        }

    }

    [SerializeField]
    private float price_13mm;

    public float Price_13mm
    {
        get
        {
            return price_13mm;
        }

    }

    [SerializeField]
    private float price_16mm;

    public float Price_16mm
    {
        get
        {
            return price_16mm;
        }

    }

    [SerializeField]
    private float price_20mm;

    public float Price_20mm
    {
        get
        {
            return price_20mm;
        }

    }

    [SerializeField]
    private float price_24mm;

    public float Price_24mm
    {
        get
        {
            return price_24mm;
        }

    }

    [SerializeField]
    private float price_28mm;

    public float Price_28mm
    {
        get
        {
            return price_28mm;
        }

    }

    [SerializeField]
    private float price_32mm;

    public float Price_32mm
    {
        get
        {
            return price_32mm;
        }

    }

}
