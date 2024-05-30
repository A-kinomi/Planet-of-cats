using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Cats
{
    public class CatKill : MonoBehaviour
    {
        PlayerAnimation playerAnimation;
        ConditionControl conditionControl;
        [SerializeField] Image blackPanel;
        float alpha;
        bool isKilled;

        private void Start()
        {
            playerAnimation = FindObjectOfType<PlayerAnimation>();
            conditionControl = GameObject.Find("ConditonControl").GetComponent<ConditionControl>();
            blackPanel.color = new Color(0f, 0f, 0f, 0f);
            blackPanel.enabled = false;
        }

        private void Update()
        {
            if(isKilled)
            {
                alpha += 0.5f * Time.deltaTime;
                blackPanel.color = new Color(0f, 0f, 0f, alpha);
            }
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player" && !blackPanel.enabled)
            {
                playerAnimation.isKilled = true;
                conditionControl.wasKilled = true;
                blackPanel.enabled = true;
                StartCoroutine(Killed());
            }
        }

        IEnumerator Killed()
        {
            yield return new WaitForSeconds(1.5f);
            isKilled = true;
            StartCoroutine(ReturnToScene1());
        }
        IEnumerator ReturnToScene1()
        {
            yield return new WaitForSeconds(3.0f);
            isKilled = false;
            
            SceneManager.LoadScene(1);
        }
    }
}
