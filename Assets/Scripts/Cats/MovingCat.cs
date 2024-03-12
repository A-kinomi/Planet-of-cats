using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cats
{
public class MovingCat : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 1f;

    private Vector2 firstPosition;
    public Transform secondPosition;

    private Vector2 targetPosition;
    private bool isMovingToPlayer = false;
    private bool isMovingToSecondPosition;

    private void Start()
    {
        firstPosition = transform.position;
        targetPosition = secondPosition.position;
        isMovingToSecondPosition = true;
    }

    void Update()
    {
        if (!isMovingToPlayer)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, targetPosition) < 0.1)
            {
                SwitchDirection();
                // TODO: sleep for a while?
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isMovingToPlayer = true;

        if(collision.tag == "Player")
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isMovingToPlayer = false;
        }
    }

    private void SwitchDirection()
    {
        if (isMovingToSecondPosition)
        {
            targetPosition = firstPosition;
            isMovingToSecondPosition = false;
        }
        else
        {
            targetPosition = secondPosition.position;
            isMovingToSecondPosition = true;
        }
    }
}
}