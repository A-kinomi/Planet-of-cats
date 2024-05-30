using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickUpItems : MonoBehaviour
{
    [SerializeField] float pickUpDuration = 0.7f;
    private WaitForSeconds showWindowDuration;
    [SerializeField] GameObject thisItemWindow;
    [SerializeField] ItemTypeEnum itemType;
    ConditionControl conditionControl;


    private void Start()
    {
        showWindowDuration = new WaitForSeconds(pickUpDuration);
        conditionControl = GameObject.Find("ConditonControl").GetComponent<ConditionControl>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !conditionControl.wasKilled)
        {
            switch (this.itemType)
            {
                case ItemTypeEnum.ShipPart1:
                    StartCoroutine(ShowShipPart1Window());
                    break;

                case ItemTypeEnum.ShipPart2:
                    StartCoroutine(ShowShipPart2Window());
                    break;

                case ItemTypeEnum.ShipPart3:
                    StartCoroutine(ShowShipPart3Window());
                    break;

                case ItemTypeEnum.ShipPart4:
                    StartCoroutine(ShowShipPart4Window());
                    break;

                case ItemTypeEnum.Milk:
                    StartCoroutine(ShowMilkWindow());
                    break;

                case ItemTypeEnum.Hint:
                    StartCoroutine(ShowHintWindow());
                    break;
            }
        }
    }

    void PickUpRoutine()
    {
        thisItemWindow.SetActive(true);
        Destroy(gameObject);
    }

    private IEnumerator ShowShipPart1Window()
    {
        yield return showWindowDuration;
        ItemInventory.instance.hasShipPart1 = true;
        PickUpRoutine();
    }

    private IEnumerator ShowShipPart2Window()
    {
        yield return showWindowDuration;
        ItemInventory.instance.hasShipPart2 = true;
        PickUpRoutine();
    }

    private IEnumerator ShowShipPart3Window()
    {
        yield return showWindowDuration;
        ItemInventory.instance.hasShipPart3 = true;
        PickUpRoutine();
    }

    private IEnumerator ShowShipPart4Window()
    {
        yield return showWindowDuration;
        ItemInventory.instance.hasShipPart4 = true;
        PickUpRoutine();
    }

    private IEnumerator ShowMilkWindow()
    {
        yield return showWindowDuration;
        ItemInventory.instance.hasMilk = true;
        PickUpRoutine();
    }

    private IEnumerator ShowHintWindow()
    {
        yield return showWindowDuration;
        ItemInventory.instance.hasHint = true;
        PickUpRoutine();
    }
}