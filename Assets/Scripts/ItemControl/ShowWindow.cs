using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWindow : MonoBehaviour
{
    [SerializeField] GameObject shipPart1Window;
    [SerializeField] GameObject shipPart2Window;
    [SerializeField] GameObject shipPart3Window;
    [SerializeField] GameObject shipPart4Window;
    [SerializeField] GameObject milkWindow;
    [SerializeField] GameObject hintWindow;

    ItemWindow itemWindow;

    PickUpItems pickUpItems;
    [SerializeField] GameObject shipPart;
    [SerializeField] GameObject milk;
    [SerializeField] GameObject hint;

    void Start()
    {
        itemWindow = FindObjectOfType<ItemWindow>();
        SwhichItemWIndow();

        shipPart = GameObject.Find("ShipParts");
    }

    void SwhichItemWIndow()
    {   
        if (itemWindow.HasShipPart1() == true)
        {
            shipPart1Window.SetActive(true);
            if(shipPart.tag == "ShipPart1" && shipPart != null)
            {
                shipPart.SetActive(false);
            }
        }
        if (itemWindow.HasShipPart2() == true)
        {
            shipPart2Window.SetActive(true);
            if (shipPart.tag == "ShipPart2" && shipPart != null)
            {
                shipPart.SetActive(false);
            }
        }
        if (itemWindow.HasShipPart3() == true)
        {
            shipPart3Window.SetActive(true);
            if (shipPart.tag == "ShipPart3" && shipPart != null) 
            {
                shipPart.SetActive(false);
            }
        }
        if (itemWindow.HasShipPart4() == true)
        {
            shipPart4Window.SetActive(true);
            if (shipPart.tag == "ShipPart4" && shipPart != null)
            {
                shipPart.SetActive(false);
            }
        }
        if (itemWindow.HasMilk() == true)
        {
            milkWindow.SetActive(true);
            if(milk != null)
            {
                milk.SetActive(false);
            }
        }
        if (itemWindow.HasHint() == true)
        {
            hintWindow.SetActive(true);
            if(hint != null)
            {
                hint.SetActive(false);
            }
        }
    }
}
