using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    [SerializeField] Image blackPanel;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag== "Player")
        {
            blackPanel.enabled = true;
            StartCoroutine(WaitForTeleport());
        }
    }

    IEnumerator WaitForTeleport()
    {
        yield return new WaitForSeconds(1.5f);
        blackPanel.color = new Color(0f, 0f, 0f, 1f);
        StartCoroutine(TeleportToScene3());
    }

    IEnumerator TeleportToScene3()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(3);
    }
}
