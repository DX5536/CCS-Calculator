using UnityEngine;

[CreateAssetMenu(fileName = "Price", menuName = "ScriptableObject/PriceData/SpecialAddOn", order = 4)]
public class SpecialAddOnPriceFactor_SO: ScriptableObject
{
    [Header("Special Add-Ons")]
    [Tooltip("Prägung: Bachelor/Masterarbeit")]
    [SerializeField]
    private float prePressed;

    public float PrePressed
    {
        get
        {
            return prePressed;
        }
    }

    [Tooltip("Custom foil print with FoilXPress")]
    [SerializeField]
    private float foilPressed;
    public float FoilPressed
    {
        get
        {
            return foilPressed;
        }
        set
        {
            foilPressed = value;
        }
    }

    [SerializeField]
    private float chanelDruck;

    public float ChanelDruck
    {
        get
        {
            return chanelDruck;
        }
    }

    [SerializeField]
    private float bookmarkRibbon;

    public float BookmarkRibbon
    {
        get
        {
            return bookmarkRibbon;
        }
    }

    [Header("Should be in a set of 4")]
    [SerializeField]
    private float bookCorner;

    public float BookCorner
    {
        get
        {
            return bookCorner;
        }
    }



}
