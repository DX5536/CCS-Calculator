using UnityEngine;

public class SpiralCalculation_Behaviour: MonoBehaviour
{
    [Header("80g")]
    [SerializeField]
    private PaperPriceFactor_SO[] black_80_pagePrices;
    [SerializeField]
    private PaperPriceFactor_SO[] color_80_pagePrices;
    [Header("120g")]
    [SerializeField]
    private PaperPriceFactor_SO[] black_120_pagePrices;
    [SerializeField]
    private PaperPriceFactor_SO[] color_120_pagePrices;

    [Header("Binding Art")]
    [SerializeField]
    private PaperPriceFactor_SO[] bindingArtPrices;

    //Bool value to check if it's 80g, if not it means it's 120g
    [SerializeField]
    private bool is80g;
    //Bool value to check if it's colored print, if not it means it's s/w print
    [SerializeField]
    private bool isColor;
    //Bool value to check if it is printed here, if not it means paper is bought by customer
    [SerializeField]
    private bool isPrintedHere;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateValue_Spiral()
    {

    }

    //public method to access from button
    public void Spiral_A4_PrintHere()
    {

    }
}
