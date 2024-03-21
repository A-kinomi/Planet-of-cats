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

    [SerializeField] GameObject shipPart1Window;
    [SerializeField] GameObject shipPart2Window;
    [SerializeField] GameObject shipPart3Window;
    [SerializeField] GameObject shipPart4Window;
    [SerializeField] GameObject milkWindow;
    [SerializeField] GameObject hintWindow;

    public ItemWindow instance;

    void Start()
    {
        if (instance != null && this != instance)
        {
            Destroy(this.gameObject);
            print("delete");
            // ToDo This object has to be deleted when going back to Scene2. 
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }


    public bool HasShipPart1()
    {
        return hasShipPart1;
    }
    public bool HasShipPart2()
    {
        return hasShipPart2;
    }
    public bool HasShipPart3()
    {
        return hasShipPart3;
    }
    public bool HasShipPart4()
    {
        return hasShipPart4;
    }
    public bool HasMilk()
    {
        return hasMilk;
    }
    public bool HasHint()
    {
        return hasHint;
    }
}
