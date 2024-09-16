using UnityEngine;

public class BindingCalculator: MonoBehaviour
{
    [Header("80g")]
    [SerializeField]
    private PriceFactor_SO[] black_80_pagePrices;
    [SerializeField]
    private PriceFactor_SO[] color_80_pagePrices;
    [Header("120g")]
    [SerializeField]
    private PriceFactor_SO[] black_120_pagePrices;
    [SerializeField]
    private PriceFactor_SO[] color_120_pagePrices;

    [Header("Binding Art")]
    [SerializeField]
    private PriceFactor_SO[] bindingArtPrices;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
