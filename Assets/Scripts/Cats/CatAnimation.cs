using System.Collections;
using System.Collections.Generic;
using Cats;
using UnityEngine;

public class CatAnimation : MonoBehaviour
{
    public Animator catAnimator;
    public Vector2 currentPos;
    public Vector2 latestPos;
    UseMilk useMilk;
    GameObject player;
    public AudioSource catVoiceSound;

    private void Awake()
    {
        catAnimator = GetComponent<Animator>();
        useMilk = FindObjectOfType<UseMilk>();
        player = GameObject.Find("Player");
        catVoiceSound = GetComponent<AudioSource>();
    }

    public void FlipSprite()
    {
        if(player.transform.position.x > this.transform.position.x)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        else if(player.transform.position.x < this.transform.position.x)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
    }

    public void MoveVertically()
    {
        if (Mathf.Sign(currentPos.y - latestPos.y) < Mathf.Epsilon)
        {
            catAnimator.SetBool("isMovingForward", true);
            catAnimator.SetBool("isMovingBack", false);
        }
        if (Mathf.Sign(currentPos.y - latestPos.y) > Mathf.Epsilon)
        {
            catAnimator.SetBool("isMovingBack", true);
            catAnimator.SetBool("isMovingForward", false);
        }
    }

    public void Attacking()
    {
        catVoiceSound.Play();
        catAnimator.SetBool("isAttacking", true);
        FlipSprite();
    }

    public void LoveMilk()
    {
        if (useMilk && useMilk.isMilkPut)
        {
            catAnimator.SetBool("isMilkUsed", true);
            transform.localScale = new Vector2(1f, 1f);
        }
    }
}
