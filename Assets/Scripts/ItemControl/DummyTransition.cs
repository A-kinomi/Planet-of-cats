using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DummyTransition : MonoBehaviour
{

    public void Scene2to3Button()
    {
        SceneManager.LoadScene(3);
    }

    public void Scene2to4Button()
    {
        SceneManager.LoadScene(4);
    }

    public void Scene2to5Button()
    {
        SceneManager.LoadScene(5);
    }
    public void Scene2to1Button()
    {
        SceneManager.LoadScene(1);
    }
    public void SceneTo2Button()
    {
        SceneManager.LoadScene(2);
    }
}
