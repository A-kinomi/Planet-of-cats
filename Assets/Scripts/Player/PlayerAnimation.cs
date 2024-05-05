using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator playerAnimatior;
    private Vector2 mousePosition;
    public bool isKilled = false;

    void Start()
    {
        playerAnimatior = GetComponent<Animator>();
        playerAnimatior.SetBool("isStart", false);
        isKilled = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerAnimatior.SetBool("isStart", true);
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        FlipSprite();
        changeSpliteDirecrtion();
        stayStanding();
        killedReaction();
    }

    void FlipSprite()
    {
        if (mousePosition.x > transform.position.x)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        if (mousePosition.x < transform.position.x)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
    }

    void changeSpliteDirecrtion()
    {
        if(Mathf.Abs(mousePosition.x - transform.position.x) > Mathf.Abs(mousePosition.y - transform.position.y))
        {
            playerAnimatior.SetBool("isMoving", true);
            playerAnimatior.SetBool("isMovingSide", true);
            playerAnimatior.SetBool("isMovingUp", false);
            playerAnimatior.SetBool("isMovingDown", false);
        }
        else if(Mathf.Abs(mousePosition.x - transform.position.x) < Mathf.Abs(mousePosition.y - transform.position.y))
        {
            playerAnimatior.SetBool("isMoving", true);
            playerAnimatior.SetBool("isMovingSide", false);

            if (Mathf.Sign(mousePosition.y - transform.position.y) > Mathf.Epsilon)
            {
                playerAnimatior.SetBool("isMovingUp", true);
                playerAnimatior.SetBool("isMovingDown", false);
            }
            if (Mathf.Sign(mousePosition.y - transform.position.y) < Mathf.Epsilon)
            {
                playerAnimatior.SetBool("isMovingDown", true);
                playerAnimatior.SetBool("isMovingUp", false);
            }
        }
    }

    void stayStanding()
    {
        if((Vector2)mousePosition == (Vector2)transform.position )
        {
            playerAnimatior.SetBool("isMoving", false);
        }
    }

    void killedReaction()
    {
        if(isKilled == true)
        {
            playerAnimatior.SetBool("isKilled", true);
        }
    }
}
