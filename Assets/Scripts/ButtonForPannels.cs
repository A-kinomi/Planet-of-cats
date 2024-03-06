using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForPannels : MonoBehaviour
{
    public GameObject howToPlayPanel;
    public GameObject creditsPanel;

    private void Start()
    {
        howToPlayPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

  
    public void HowToPlay()
    {
        howToPlayPanel.SetActive(true);
    }

    public void Credits()
    {
        creditsPanel.SetActive(true);
    }

    public void Close()
    {
        if(howToPlayPanel)
        {
            howToPlayPanel.SetActive(false);
        }
        if(creditsPanel)
        {
            creditsPanel.SetActive(false);
        }
    }
}
