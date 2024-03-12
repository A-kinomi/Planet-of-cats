using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cats
{
public class CatKill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("You got killed!");
    }
}
}
