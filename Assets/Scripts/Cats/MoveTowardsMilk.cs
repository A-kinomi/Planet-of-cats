using System.Collections;
using System.Collections.Generic;
using Cats;
using UnityEngine;

public class MoveTowardsMilk : MonoBehaviour
{
    [SerializeField] float speed = 0.9f;
    [SerializeField] Transform milkStand;
    UseMilk useMilk;
    [SerializeField] CapsuleCollider2D catBodyCollider;
    Cats.StationaryCat stationaryCat;

    private void Start()
    {
        useMilk = FindObjectOfType<UseMilk>();
        catBodyCollider = GetComponent<CapsuleCollider2D>();
        stationaryCat = GetComponent<Cats.StationaryCat>();
    }


    void Update()
    {
        if(useMilk.isMilkPut && !stationaryCat.isMovingToPlayer)
        {
            stationaryCat.isMovingToStart = false;
            transform.position = Vector2.MoveTowards(transform.position, milkStand.position, speed * Time.deltaTime);
        }
    }
}
