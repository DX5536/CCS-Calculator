using UnityEngine;

[CreateAssetMenu(fileName = "PagesAmount_SO", menuName = "ScriptableObject/NonPrice/Pages", order = 1)]
public class PagesAmount_SO: ScriptableObject
{
    [SerializeField]
    private int pagesAmount;

    public int PagesAmount
    {
        get
        {
            return pagesAmount;
        }
        set
        {
            pagesAmount = value;
        }
    }




}
