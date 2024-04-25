using System.Collections;
using System.Collections.Generic;
using Cats;
using UnityEngine;
using UnityEngine.UI;

public class UseMilk : MonoBehaviour
{
    public bool isMilkPut = false;
    ItemWindow itemWindow;
    ShowWindow showWindow;
    [SerializeField] GameObject useMilkPanel;
    [SerializeField] GameObject milkButton;
    [SerializeField] GameObject shipPart1Button;
    [SerializeField] GameObject shipPart2Button;
    [SerializeField] GameObject wrongItemPanel;
    [SerializeField] GameObject youDontHaveItemsPanel;

    void Start()
    {
        itemWindow = FindObjectOfType<ItemWindow>();
        showWindow = FindObjectOfType<ShowWindow>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            useMilkPanel.SetActive(true);
            Time.timeScale = 0;

            if (!itemWindow.hasShipPart1)
            {
                shipPart1Button.SetActive(false);
            }
            if (!itemWindow.hasShipPart2)
            {
                shipPart2Button.SetActive(false);
            }
            if (!itemWindow.hasMilk)
            {
                milkButton.SetActive(false);
            }
            if (!itemWindow.hasShipPart1 && !itemWindow.hasShipPart2 && !itemWindow.hasMilk)
            {
                StartCoroutine(YouDontHaveItems());
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" && useMilkPanel)
        {
            if (itemWindow.hasMilk)
            {
                useMilkPanel.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    public void PutMilkToStand()
    {
        isMilkPut = true;
        useMilkPanel.SetActive(false);
        itemWindow.hasMilk = false;
        showWindow.milkWindow.SetActive(false);
        Time.timeScale = 1;
    }

    public void ChooseWrongItem()
    {
        StartCoroutine(ShowWrongItemPanel());
    }

    IEnumerator ShowWrongItemPanel()
    {
        wrongItemPanel.SetActive(true);
        yield return new WaitForSecondsRealtime(1.3f);
        wrongItemPanel.SetActive(false);
    }
    IEnumerator YouDontHaveItems()
    {
        youDontHaveItemsPanel.SetActive(true);
        yield return new WaitForSecondsRealtime(2f);
        youDontHaveItemsPanel.SetActive(false);
        useMilkPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
