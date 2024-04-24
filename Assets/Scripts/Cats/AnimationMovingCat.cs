using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMovingCat : MonoBehaviour
{
    Animator catAnimator;
    Cats.MovingCat movingCat;
    bool catAttacking;
    Vector2 currentPos;
    Vector2 latestPos;

    void Start()
    {
        catAnimator = GetComponent<Animator>();
        movingCat = GetComponent<Cats.MovingCat>();
    }

    
    void Update()
    {
        currentPos = this.transform.position;
        MoveVertically();

        latestPos = this.transform.position;
    }

    void MoveVertically()
    {
        if (!movingCat.isMovingToPlayer)
        {
            if (Mathf.Sign(currentPos.y - latestPos.y) < 0)
            {
                catAnimator.SetBool("isMovingForward", true);
                catAnimator.SetBool("isMovingBack", false);
            }
            if (Mathf.Sign(currentPos.y - latestPos.y) > 0)
            {
                catAnimator.SetBool("isMovingBack", true);
                catAnimator.SetBool("isMovingForward", false);
            }
        }
    }

    void MoveForward()
    {
        catAnimator.SetBool("isMovingForward", true);
        catAnimator.SetBool("isMovingBack", false);
    }

    void MoveBack()
    {
        catAnimator.SetBool("isMovingBack", true);
        catAnimator.SetBool("isMovingForward", false);
    }

    void Attacking()
    {
        if (movingCat.isMovingToPlayer)
        {
            //catAnimator.SetBool("isAttacking", true);
        }
    }
}
