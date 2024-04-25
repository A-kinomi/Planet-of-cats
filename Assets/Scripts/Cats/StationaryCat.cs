using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cats
{
    public class StationaryCat : MonoBehaviour
    {
        [SerializeField] private Transform player;
        [SerializeField] private float attackSpeed = 0.8f;

        private Vector2 startPosition;
        public bool isMovingToStart = false;
        public bool isMovingToPlayer = false;

        private void Start()
        {
            startPosition = transform.position;
        }

        private void Update()
        {
            if (isMovingToStart)
            {
                transform.position = Vector2.MoveTowards(transform.position, startPosition, attackSpeed * Time.deltaTime);
                if (Vector2.Distance(transform.position, startPosition) < 0.1)
                {
                    isMovingToStart = false;
                }
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                isMovingToStart = false;
                isMovingToPlayer = true;
                transform.position = Vector2.MoveTowards(transform.position, player.position, attackSpeed * Time.deltaTime);
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                isMovingToStart = true;
                isMovingToPlayer = false;
            }
        }
    }
}
