using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cats
{
    public class CatKill : MonoBehaviour
    {
        PlayerAnimation playerAnimation;

        private void Start()
        {
             playerAnimation = FindObjectOfType<PlayerAnimation>();

        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                print("You got killed!");
                playerAnimation.isKilled = true;
            }
        }
    }
}
