using TMPro;
using UnityEngine;

public class UpdatePagesAmount: MonoBehaviour
{
    [SerializeField]
    private TMP_InputField pagesAmount_TMP;

    [SerializeField]
    private PagesAmount_SO currentPageAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("UpdateAmount", 0, 1);
    }

    private void UpdateAmount()
    {
        //Check if there is anything in pageAmount
        if (pagesAmount_TMP.text == "")
        {
            //Debug.Log("There is no pages!");
            currentPageAmount.PagesAmount = 0;
            return;
        }

        else
        {
            //If any key has been pressed -> Update the pagesAmount
            if (Input.anyKeyDown)
            {
                currentPageAmount.PagesAmount = int.Parse(pagesAmount_TMP.text);
                //Debug.Log("A key has been pressed, is updating Page amount");

            }
        }

    }
}
