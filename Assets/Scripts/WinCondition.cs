using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    [SerializeField] Sprite fixedShipSprite;
    [SerializeField] Image blackPanel;
    private float alpha = 0f;
    bool isBlackScreen;


    private void Update()
    {
        if(!isBlackScreen)
        {
            blackPanel.enabled = false;
        }
        BlackScreen();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ItemWindow.instance.hasShipPart1 == true
            && ItemWindow.instance.hasShipPart2 == true
            && ItemWindow.instance.hasShipPart3 == true
            && ItemWindow.instance.hasShipPart4 == true)
        {
            isBlackScreen = true;
            blackPanel.enabled = true;
        }
    }

    void BlackScreen()
    {
        if(alpha < 1.0f && isBlackScreen)
        {
            alpha += 0.001f;
            blackPanel.color = new Color(0f, 0f, 0f, alpha);
        }

        if(alpha > 1.0f && isBlackScreen)
        {
            StartCoroutine(RepairShip());
            this.GetComponent<SpriteRenderer>().sprite = fixedShipSprite;
        }
    }

    IEnumerator RepairShip()
    {
        yield return new WaitForSeconds(1.5f);
        blackPanel.color = new Color(0f, 0f, 0f, 0f);
        EndingScene();
    }

    void EndingScene()
    {
        StartCoroutine(GoToEnding());
    }

    IEnumerator GoToEnding()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(6);
    }
}
