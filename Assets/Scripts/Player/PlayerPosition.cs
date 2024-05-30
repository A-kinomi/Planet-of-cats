using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    ConditionControl conditionControl;

    private void Start()
    {
        conditionControl = GameObject.Find("ConditonControl").GetComponent<ConditionControl>();

        if(conditionControl.wasScene1)
        {
            this.transform.position = new Vector2(0f, -4f);
        }

        if(conditionControl.wasScene2)
        {
            this.transform.position = new Vector2(0f, 4f);
        }

        if(conditionControl.wasScene3)
        {
            this.transform.position = new Vector2(-7.2f, 0f);
        }

        if(conditionControl.wasScene4)
        {
            this.transform.position = new Vector2(0f, 4f);
        }

        if(conditionControl.wasScene5)
        {
            this.transform.position = new Vector2(7.2f, 0f);
        }

        if(conditionControl.wasKilled)
        {
            this.transform.position = new Vector2(0f, 0f);
        }
    }
}
