using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventory : MonoBehaviour 
{
    public bool hasShipPart1 = false;
    public bool hasShipPart2 = false;
    public bool hasShipPart3 = false;
    public bool hasShipPart4 = false;
    public bool hasMilk = false;
    public bool hasHint = false;

    public bool wasScene1;
    public bool wasScene2;
    public bool wasScene3;
    public bool wasScene4;
    public bool wasScene5;
    public bool wasKilled;

    public static ItemInventory instance;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    } 
}
