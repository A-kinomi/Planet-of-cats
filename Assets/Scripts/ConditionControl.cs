using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionControl : MonoBehaviour
{
    public bool wasScene1;
    public bool wasScene2;
    public bool wasScene3;
    public bool wasScene4;
    public bool wasScene5;
    public bool wasKilled;

    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
