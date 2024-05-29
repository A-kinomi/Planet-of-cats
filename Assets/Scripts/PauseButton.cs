using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    AudioSource playerWalkSound;
    GameObject bgm;
    [SerializeField] GameObject pausePanel;

    private void Start()
    {
        playerWalkSound = GameObject.Find("Player").GetComponent<AudioSource>();
        bgm = GameObject.Find("BGM");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        playerWalkSound.Stop();
    }

    public void Exit()
    {
        Time.timeScale = 1;
        ItemInventory.instance.wasScene1 = false;
        ItemInventory.instance.wasScene2 = false;
        ItemInventory.instance.wasScene3 = false;
        ItemInventory.instance.wasScene4 = false;
        ItemInventory.instance.wasScene5 = false;

        ItemInventory.instance.hasShipPart1 = false;
        ItemInventory.instance.hasShipPart2 = false;
        ItemInventory.instance.hasShipPart3 = false;
        ItemInventory.instance.hasShipPart4 = false;
        ItemInventory.instance.hasMilk = false;
        ItemInventory.instance.hasHint = false;
        Destroy(bgm);
        SceneManager.LoadScene(0);
    }

    public void BackToGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        playerWalkSound.Play();
    }
}