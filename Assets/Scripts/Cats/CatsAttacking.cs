using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsAttacking : MonoBehaviour
{
    
    [SerializeField] Transform player;
    [SerializeField] float attackSpeed = 0.8f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, attackSpeed * Time.deltaTime);
        }
    }
 }
