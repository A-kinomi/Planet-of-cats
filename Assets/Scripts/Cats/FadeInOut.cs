using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInOut : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] float fadeDuration = 3.5f;
    [SerializeField] bool isFadeOut;
    [SerializeField] CircleCollider2D catCollider; //Killing collider in children
    [SerializeField] float currentFadeTime;
    float alphaValue;


    void Update()
    {
        CatFadeInAndOut();
        ColliderEnabled();
        currentFadeTime += Time.deltaTime;
    }


    void CatFadeInAndOut()
    {
        if (currentFadeTime < fadeDuration)
        {
            if (isFadeOut == true)
            {
                alphaValue = 1 - (currentFadeTime / fadeDuration);
                material.color = new Color(1.0f, 1.0f, 1.0f, alphaValue);
                currentFadeTime += Time.deltaTime;
            }
            else
            {
                alphaValue = currentFadeTime / fadeDuration;
                material.color = new Color(1.0f, 1.0f, 1.0f, alphaValue);
                
            }
        }

        if (currentFadeTime > fadeDuration + 3.0f)
        {
            if (isFadeOut == true)
            {
                isFadeOut = false;
            }
            else
            {
                isFadeOut = true;
            }
            currentFadeTime = 0f;
        }
    }

    public void ColliderEnabled()
    {
        if(alphaValue < 0.3f)
        {
            this.catCollider.enabled = false;
        }
        else
        {
            this.catCollider.enabled = true;
        }
    }
}
