using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    [SerializeField] float pickUpDuration = 0.7f;
    private WaitForSeconds showWindowDuration;

    [SerializeField] GameObject itemWindow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine(ShowItemInWindow());
        }
    }

    private IEnumerator ShowItemInWindow()
    {
        showWindowDuration = new WaitForSeconds(pickUpDuration);
        
        yield return showWindowDuration;
        itemWindow.SetActive(true);
        Destroy(gameObject);
    }
}
