using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Telop : MonoBehaviour
{
    [TextArea(1,3)]
    [SerializeField] List<string> monologueList = new List<string>();
    [SerializeField] TextMeshProUGUI monologueText;
    [SerializeField] float telopSpeed;
    int monologueListIndex = 0; //list index number of sentences
    int charactorCount; //each character in the sentence
    AudioSource crashSound;
    AudioSource audioBGM;

    void Start()
    {
        crashSound = GameObject.Find("Sounds").GetComponent<AudioSource>();
        audioBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        StartCoroutine(StartSound());
    }
    IEnumerator StartSound()
    {
        yield return new WaitForSeconds(0.5f);
        crashSound.Play();
        StartCoroutine(StartMonologue());
    }

    IEnumerator StartMonologue()
    {
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(StartTelop());
    }

    IEnumerator StartTelop()
    {
        charactorCount = 0;
        monologueText.text = "";

        while (monologueList[monologueListIndex].Length > charactorCount)
        {
            monologueText.text += monologueList[monologueListIndex][charactorCount];
            charactorCount++;
            yield return new WaitForSeconds(telopSpeed);
        }
    }

    public void NextText()
    {
        monologueListIndex++;

        if (monologueListIndex < monologueList.Count)
        {
            StartCoroutine(StartTelop());
        }
        else
        {
            SkipMonologue();
        }
    }

    public void SkipMonologue()
    {
        audioBGM.Play();
        SceneManager.LoadScene(1);
    }
}
