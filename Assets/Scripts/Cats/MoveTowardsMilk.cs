using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsMilk : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform milkStand;
    UseMilk useMilk;

    private void Start()
    {
        useMilk = FindObjectOfType<UseMilk>();
    }


    void Update()
    {
        if(useMilk.isMilkPut)
        {
            transform.position = Vector2.MoveTowards(transform.position, milkStand.position, speed * Time.deltaTime);
        }
    }
}
