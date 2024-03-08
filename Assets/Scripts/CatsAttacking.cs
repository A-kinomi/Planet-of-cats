using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CatsAttacking : MonoBehaviour
{
    [SerializeField] Transform player;
    private NavMeshAgent cats;
    bool isCatsClose = false;

    void Start()
    {
        cats = GetComponent<NavMeshAgent>();
        cats.updateRotation = false;
        cats.updateUpAxis = false;
    }


    void Update()
    {
        if (isCatsClose)
        {
            cats.SetDestination(player.position);
        }
        else if (!isCatsClose)
        {
            cats.SetDestination(gameObject.transform.position);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isCatsClose = true;
            print("start attacking!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isCatsClose = false;
            print("byebye!");
        }
    }
}
