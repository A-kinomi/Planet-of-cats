using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWindow : MonoBehaviour
{
    [SerializeField] GameObject shipPart1Window;
    [SerializeField] GameObject shipPart2Window;
    [SerializeField] GameObject shipPart3Window;
    [SerializeField] GameObject shipPart4Window;
    public GameObject milkWindow;
    public GameObject hintWindow;

    ItemInventory itemWindow;

    PickUpItems pickUpItems;
    [SerializeField] GameObject shipPart;
    [SerializeField] GameObject milk;
    [SerializeField] GameObject hint;

    void Start()
    {
        itemWindow = FindObjectOfType<ItemInventory>();
        SwhichItemWIndow();

        shipPart = GameObject.Find("ShipParts");
    }

    void SwhichItemWIndow()
    {   
        if (itemWindow.hasShipPart1 == true)
        {
            shipPart1Window.SetActive(true);
            if(shipPart.tag == "ShipPart1" && shipPart != null)
            {
                shipPart.SetActive(false);
            }
        }
        if (itemWindow.hasShipPart2 == true)
        {
            shipPart2Window.SetActive(true);
            if (shipPart.tag == "ShipPart2" && shipPart != null)
            {
                shipPart.SetActive(false);
            }
        }
        if (itemWindow.hasShipPart3 == true)
        {
            shipPart3Window.SetActive(true);
            if (shipPart.tag == "ShipPart3" && shipPart != null) 
            {
                shipPart.SetActive(false);
            }
        }
        if (itemWindow.hasShipPart4 == true)
        {
            shipPart4Window.SetActive(true);
            if (shipPart.tag == "ShipPart4" && shipPart != null)
            {
                shipPart.SetActive(false);
            }
        }
        if (itemWindow.hasMilk == true)
        {
            milkWindow.SetActive(true);
            if(milk != null)
            {
                milk.SetActive(false);
            }
        }
        if (itemWindow.hasHint == true)
        {
            hintWindow.SetActive(true);
            if(hint != null)
            {
                hint.SetActive(false);
            }
        }
    }
}
