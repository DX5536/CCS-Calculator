using UnityEngine;

[CreateAssetMenu(fileName = "Price", menuName = "ScriptableObject/PriceData/Hardcover", order = 1)]
public class HardcoverPriceFactor_SO: ScriptableObject
{
    [Header("READONLY: Is hardcover Europa? If not, then Classic/Mundial")]
    [SerializeField]
    private bool isHardcoverEuropa;
    public bool IsHardcoverEuropa
    {
        get
        {
            return isHardcoverEuropa;
        }
    }

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

    [Header("80g Paper amount: If value is -1, it means this option doesn't exist")]
    [SerializeField]
    private float paper80_5mm;

    public float Paper80_5mm
    {
        get
        {
            return Paper80_5mm;
        }

    }

    [SerializeField]
    private float paper80_7mm;

    public float Paper80_7mm
    {
        get
        {
            return Paper80_7mm;
        }

    }

    [SerializeField]
    private float paper80_10mm;

    public float Paper80_10mm
    {
        get
        {
            return Paper80_10mm;
        }

    }

    [SerializeField]
    private float paper80_13mm;

    public float Paper80_13mm
    {
        get
        {
            return Paper80_13mm;
        }

    }

    [SerializeField]
    private float paper80_16mm;

    public float Paper80_16mm
    {
        get
        {
            return Paper80_16mm;
        }

    }

    [SerializeField]
    private float paper80_20mm;

    public float Paper80_20mm
    {
        get
        {
            return Paper80_20mm;
        }

    }

    [SerializeField]
    private float paper80_24mm;

    public float Paper80_24mm
    {
        get
        {
            return Paper80_24mm;
        }

    }

    [SerializeField]
    private float paper80_28mm;

    public float Paper80_28mm
    {
        get
        {
            return Paper80_28mm;
        }

    }

    [SerializeField]
    private float paper80_32mm;

    public float Paper80_32mm
    {
        get
        {
            return Paper80_32mm;
        }

    }

    [Header("120g Paper amount: If value is -1, it means this option doesn't exist")]
    [SerializeField]
    private float paper120_5mm;

    public float Paper120_5mm
    {
        get
        {
            return Paper120_5mm;
        }

    }

    [SerializeField]
    private float paper120_7mm;

    public float Paper120_7mm
    {
        get
        {
            return Paper120_7mm;
        }

    }

    [SerializeField]
    private float paper120_10mm;

    public float Paper120_10mm
    {
        get
        {
            return Paper120_10mm;
        }

    }

    [SerializeField]
    private float paper120_13mm;

    public float Paper120_13mm
    {
        get
        {
            return Paper120_13mm;
        }

    }

    [SerializeField]
    private float paper120_16mm;

    public float Paper120_16mm
    {
        get
        {
            return Paper120_16mm;
        }

    }

    [SerializeField]
    private float paper120_20mm;

    public float Paper120_20mm
    {
        get
        {
            return Paper120_20mm;
        }

    }

    [SerializeField]
    private float paper120_24mm;

    public float Paper120_24mm
    {
        get
        {
            return Paper120_24mm;
        }

    }

    [SerializeField]
    private float paper120_28mm;

    public float Paper120_28mm
    {
        get
        {
            return Paper120_28mm;
        }

    }

    [SerializeField]
    private float paper120_32mm;

    public float Paper120_32mm
    {
        get
        {
            return Paper120_32mm;
        }

    }

}
