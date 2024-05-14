using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseHint : MonoBehaviour
{
    [SerializeField] GameObject useHintPanel;
    [SerializeField] GameObject useKeyPanel;
    [SerializeField] GameObject hintButton;
    [SerializeField] GameObject youDontHaveItemsPanel;
    private Animator doorAnimator;
    bool isDoorOpen = false;
    [SerializeField] BoxCollider2D doorCollider;

    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !isDoorOpen)
        {
            useHintPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void NoButton()
    {
        useHintPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void YesButton()
    {
        if(ItemWindow.instance.hasHint == false)
        {
            StartCoroutine(YouDontHaveItems());
        }
        else
        {
            useKeyPanel.SetActive(true);
        }
    }

    IEnumerator YouDontHaveItems()
    {
        youDontHaveItemsPanel.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        youDontHaveItemsPanel.SetActive(false);
        useHintPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void UseHintAtDoor()
    {
        isDoorOpen = true;
        useHintPanel.SetActive(false);
        useKeyPanel.SetActive(false);

        Time.timeScale = 1;
        doorAnimator.SetBool("isUseKey", true);
        Destroy(doorCollider);
    }
}
