using UnityEngine;

[CreateAssetMenu(fileName = "Price", menuName = "ScriptableObject/PriceData/Paper", order = 0)]
public class PaperPriceFactor_SO: ScriptableObject
{
    [SerializeField]
    private float paper80g_SW;

    public float Paper80g_SW
    {
        get
        {
            return paper80g_SW;
        }
    }

    [SerializeField]
    private float paper80_Col;

    public float Paper80_Col
    {
        get
        {
            return paper80_Col;
        }
    }

    [SerializeField]
    private float paper120g_SW;

    public float Paper120g_SW
    {
        get
        {
            return paper120g_SW;
        }
    }

    [SerializeField]
    private float paper120_Col;

    public float Paper120_Col
    {
        get
        {
            return paper120_Col;
        }
    }

}
