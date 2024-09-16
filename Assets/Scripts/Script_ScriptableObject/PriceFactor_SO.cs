using UnityEngine;

[CreateAssetMenu(fileName = "Price", menuName = "ScriptableObject/PriceData", order = 0)]
public class PriceFactor_SO: ScriptableObject
{
    [SerializeField]
    private float price;

    public float Price
    {
        get
        {
            return price;
        }
    }

}
