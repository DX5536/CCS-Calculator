using UnityEngine;

public class Softcover_Calculation: MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
