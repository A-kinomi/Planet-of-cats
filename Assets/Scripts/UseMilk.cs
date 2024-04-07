using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseMilk : MonoBehaviour
{
    public bool isMilkPut = false;
    ItemWindow itemWindow;
    [SerializeField] GameObject useMilkPanel;
    [SerializeField] GameObject shipPart1Button;
    [SerializeField] GameObject shipPart2Button;
    [SerializeField] GameObject wrongItemPanel;
    [SerializeField] WaitForSeconds timeToShowWrongItemPanel;

    void Start()
    {
        itemWindow = FindObjectOfType<ItemWindow>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && itemWindow.hasMilk)
        {
            
            useMilkPanel.SetActive(true);

            if(itemWindow.hasShipPart1 == true)
            {
                shipPart1Button.SetActive(true);
            }
            if (itemWindow.hasShipPart2 == true)
            {
                shipPart2Button.SetActive(true);
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (itemWindow.hasMilk)
            {
                useMilkPanel.SetActive(false);
            }
        }
    }

    public void PutMilkToStand()
    {
        isMilkPut = true;
        useMilkPanel.SetActive(false);
    }

    public void ChooseWrongItem()
    {
        StartCoroutine(ShowWrongItemPanel());
    }

    IEnumerator ShowWrongItemPanel()
    {
        wrongItemPanel.SetActive(true);

        yield return timeToShowWrongItemPanel;
        wrongItemPanel.SetActive(false);
    }
}
