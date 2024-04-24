using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsMilk : MonoBehaviour
{
    [SerializeField] float speed = 0.9f;
    [SerializeField] Transform milkStand;
    UseMilk useMilk;
    [SerializeField] CapsuleCollider2D catBodyCollider;

    private void Start()
    {
        useMilk = FindObjectOfType<UseMilk>();
        catBodyCollider = GetComponent<CapsuleCollider2D>();
    }


    void Update()
    {
        if(useMilk.isMilkPut)
        {
            transform.position = Vector2.MoveTowards(transform.position, milkStand.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (catBodyCollider.IsTouchingLayers(LayerMask.GetMask("Cats")) && useMilk.isMilkPut)
        {
            speed = 0.1f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Cats" && useMilk.isMilkPut)
        {
            speed = 0.9f;
        }
    }
}
