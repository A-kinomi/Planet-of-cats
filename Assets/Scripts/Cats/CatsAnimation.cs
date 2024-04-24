using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatsAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Start()
    {
        animator.Play(animator.GetCurrentAnimatorStateInfo(0).shortNameHash, 0, Random.Range(0f, 1f));
    }
}
