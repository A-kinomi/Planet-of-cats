using System.Collections;
using System.Collections.Generic;
using Cats;
using UnityEngine;

public class AnimationStationaryCat : CatAnimation
{
    Cats.StationaryCat stationaryCat;
    bool catAttacking;

    void Start()
    {
        stationaryCat = GetComponent<Cats.StationaryCat>();
        catAnimator.Play(catAnimator.GetCurrentAnimatorStateInfo(0).shortNameHash, 0, Random.Range(0f, 1f));
    }

    void Update()
    {
        currentPos = this.transform.position;

        ReturnToPosition();
        StartAttacking();
        LoveMilk();

        latestPos = this.transform.position;
    }

    void ReturnToPosition()
    {
        if (stationaryCat.isMovingToStart)
        {
            MoveVertically();
        }
        if (!stationaryCat.isMovingToStart)
        {
            catAnimator.SetBool("isMovingForward", false);
            catAnimator.SetBool("isMovingBack", false);
        }
    }

    void StartAttacking()
    {
        if (stationaryCat.isMovingToPlayer)
        {
            Attacking();
        }
        else if (!stationaryCat.isMovingToPlayer)
        {
            catAnimator.SetBool("isAttacking", false);
        }
    }
}
