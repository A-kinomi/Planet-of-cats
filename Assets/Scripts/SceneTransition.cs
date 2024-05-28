using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Crash");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (this.tag == "Scene1to2")
            {
                ItemInventory.instance.wasScene1 = true;
                ItemInventory.instance.wasScene2 = false;
                ItemInventory.instance.wasScene3 = false;
                ItemInventory.instance.wasScene4 = false;
                ItemInventory.instance.wasScene5 = false;
                ItemInventory.instance.wasKilled = false;
                SceneManager.LoadScene(2);
            }

            if (this.tag == "Scene2to3")
            {
                SceneManager.LoadScene(3);
            }

            if (this.tag == "Scene2to4")
            {
                SceneManager.LoadScene(4);
            }

            if (this.tag == "Scene2to5")
            {
                SceneManager.LoadScene(5);
            }

            if (this.tag == "Scene2to1")
            {
                ItemInventory.instance.wasScene1 = false;
                ItemInventory.instance.wasScene2 = true;
                ItemInventory.instance.wasScene3 = false;
                ItemInventory.instance.wasScene4 = false;
                ItemInventory.instance.wasScene5 = false;
                SceneManager.LoadScene(1);
            }

            if (this.tag == "Scene3to2")
            {
                ItemInventory.instance.wasScene1 = false;
                ItemInventory.instance.wasScene2 = false;
                ItemInventory.instance.wasScene3 = true;
                ItemInventory.instance.wasScene4 = false;
                ItemInventory.instance.wasScene5 = false;
                SceneManager.LoadScene(2);
            }

            if (this.tag == "Scene4to2")
            {
                ItemInventory.instance.wasScene1 = false;
                ItemInventory.instance.wasScene2 = false;
                ItemInventory.instance.wasScene3 = false;
                ItemInventory.instance.wasScene4 = true;
                ItemInventory.instance.wasScene5 = false;
                SceneManager.LoadScene(2);
            }

            if (this.tag == "Scene5to2")
            {
                ItemInventory.instance.wasScene1 = false;
                ItemInventory.instance.wasScene2 = false;
                ItemInventory.instance.wasScene3 = false;
                ItemInventory.instance.wasScene4 = false;
                ItemInventory.instance.wasScene5 = true;
                SceneManager.LoadScene(2);
            }
        }
        

    }
}
