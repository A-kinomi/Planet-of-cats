using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMovingCat : CatAnimation
{
    Cats.MovingCat movingCat;
    bool catAttacking;


    void Start()
    {
        movingCat = GetComponent<Cats.MovingCat>();
    }

    
    void Update()
    {
        currentPos = this.transform.position;
        if (!movingCat.isMovingToPlayer)
        {
            MoveVertically();
        }

        StartAttacking();
        latestPos = this.transform.position;
    }

  

    void StartAttacking()
    {
        if (movingCat.isMovingToPlayer)
        {
            Attacking();
        }
        else if(!movingCat.isMovingToPlayer)
        {
            catAnimator.SetBool("isAttacking", false);
        }
    }

}
