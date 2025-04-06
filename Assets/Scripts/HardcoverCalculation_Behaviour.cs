using UnityEngine;
using UnityEngine.UI;

public class HardcoverCalculation_Behaviour: MonoBehaviour
{
    [SerializeField]
    private Toggle isEuropa;
    [Header("How many pages are there?")]
    [SerializeField]
    private PagesAmount_SO currentPagesAmount;

    [Header("READONLY_ Is Hardcover Europa? If not, then Classic")]
    [SerializeField]
    private bool isCurrentHardcoverEuropa;
    [Header("READONLY_ What is the size of the cover? A4, A4 Quer, A5, A3, 210x210")]
    [SerializeField]
    private string currentHardcoverSize;

    [Header("Europa: ScriptableObject")]
    [SerializeField]
    private HardcoverPriceFactor_SO[] europaPriceFactor_SO;
    [Header("Classic: ScriptableObject")]
    [SerializeField]
    private HardcoverPriceFactor_SO[] classicPriceFactor_SO;

    [Header("4-0 one sided")]
    [SerializeField]
    private PaperPriceFactor_SO oneSided_pagePrices;
    [Header("4-4 double sided")]
    [SerializeField]
    private PaperPriceFactor_SO doubleSided_pagePrices;


    private void OnEnable()
    {
        //We need to access onHardcoverCalculation Event
        //We then subscribe our method to the event
        //So when Event trigger -> Method trigger
        EventManager.onHardcoverCalculation += OnHardcover_Calculation;

    }

    private void OnDisable()
    {
        //We unsubscribe our method to the event when the trigger is disable
        EventManager.onHardcoverCalculation -= OnHardcover_Calculation;

    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnHardcover_Calculation()
    {
        //First decide if we are doing Classic or Europa cover
        isCurrentHardcoverEuropa = isEuropa.isOn;


        //If it's Europa (the default)
        if (isCurrentHardcoverEuropa)
        {
            //If the size is already invalid from the start -> Say ERROR!!!
            if (string.IsNullOrEmpty(currentHardcoverSize))
            {
                Debug.Log("ERROR! No size is given in Europa");
            }
            else
            {
                //We loop through the SOs of Europa
                for (int i = 0;i < europaPriceFactor_SO.Length;i++)
                {
                    //If a particular SO's size NOT match with what we have -> Re-do loop until find one
                    if (europaPriceFactor_SO[i].HardcoverSize != currentHardcoverSize)
                    {
                        Debug.Log("ERROR! There is no Europa in this size!");
                    }
                    else
                    {
                        switch (currentHardcoverSize)
                        {
                            case "A4":
                                Debug.Log("This is Europa A4 " + europaPriceFactor_SO[i].name);
                                break;

                            case "A4 Quer":
                                Debug.Log("This is Europa A4 Quer " + europaPriceFactor_SO[i].name);
                                break;

                            case "A5":
                                Debug.Log("This is Europa A5 " + europaPriceFactor_SO[i].name);
                                break;

                        }
                    }

                }
            }


        }

        else
        {
            //If the size is already invalid from the start -> Say ERROR!!!
            if (string.IsNullOrEmpty(currentHardcoverSize))
            {
                Debug.Log("ERROR! No size is given in Classic");
            }
            else
            {
                //We loop through the SOs of Europa
                for (int i = 0;i < europaPriceFactor_SO.Length;i++)
                {
                    //If a particular SO's size NOT match with what we have -> Re-do loop until find one
                    if (europaPriceFactor_SO[i].HardcoverSize != currentHardcoverSize)
                    {
                        Debug.Log("ERROR! There is no Classic in this size!");
                    }
                    else
                    {
                        switch (currentHardcoverSize)
                        {
                            case "A3":
                                break;

                            case "A4":
                                break;

                            case "210x210":
                                break;

                            case "A5":
                                break;
                        }

                    }
                }
            }
        }
    }

    private void Hardcover_Classic()
    {

    }

    private void Hardcover_Europa()
    {

    }
}
