using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWindow : MonoBehaviour
{
    public bool hasShipPart1 = false;
    public bool hasShipPart2 = false;
    public bool hasShipPart3 = false;
    public bool hasShipPart4 = false;
    public bool hasMilk = false;
    public bool hasHint = false;

    public static ItemWindow instance;
    
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
