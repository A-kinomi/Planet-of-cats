using System.Collections;
using System.Collections.Generic;
using Cats;
using UnityEngine;
using UnityEngine.UI;

public class UseMilk : MonoBehaviour
{
    public bool isMilkPut = false;
    ShowWindow showWindow;
    [SerializeField] GameObject useMilkPanel;
    [SerializeField] GameObject milkButton;
    [SerializeField] GameObject hintButton;
    [SerializeField] GameObject shipPart1Button;
    [SerializeField] GameObject shipPart2Button;
    [SerializeField] GameObject shipPart3Button;
    [SerializeField] GameObject shipPart4Button;
    [SerializeField] GameObject wrongItemPanel;
    [SerializeField] GameObject youDontHaveItemsPanel;

    void Start()
    {
        showWindow = FindObjectOfType<ShowWindow>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            useMilkPanel.SetActive(true);
            Time.timeScale = 0;

            if (!ItemWindow.instance.hasShipPart1)
            {
                shipPart1Button.SetActive(false);
            }
            if (!ItemWindow.instance.hasShipPart2)
            {
                shipPart2Button.SetActive(false);
            }
            if (!ItemWindow.instance.hasShipPart3)
            {
                shipPart3Button.SetActive(false);
            }
            if (!ItemWindow.instance.hasShipPart4)
            {
                shipPart4Button.SetActive(false);
            }
            if (!ItemWindow.instance.hasMilk)
            {
                milkButton.SetActive(false);
            }
            if (!ItemWindow.instance.hasHint)
            {
                hintButton.SetActive(false);
            }
            if (!ItemWindow.instance.hasShipPart1 && !ItemWindow.instance.hasShipPart2 && !ItemWindow.instance.hasMilk && !ItemWindow.instance.hasHint)
            {
                StartCoroutine(YouDontHaveItems());
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" && useMilkPanel)
        {
            if (ItemWindow.instance.hasMilk)
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
        ItemWindow.instance.hasMilk = false;
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

        if (!ItemWindow.instance.hasMilk)
        {
            useMilkPanel.SetActive(false);
            Time.timeScale = 1;
        }
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
