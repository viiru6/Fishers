using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PauseScript : MonoBehaviour
{
    public List<GameObject> gameObjectsToDisable = new List<GameObject>();
    public GameObject pauseMenu;
    private bool pause;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true) { if (pause) { Resume(); } else { paussi(); } }
    }
    public void Resume()
    {
        pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        foreach (GameObject gameobject in gameObjectsToDisable)
        {
            gameobject.GetComponentInChildren<Button>().interactable = true;
        }
    }
    void paussi()
    {
        pause = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        foreach(GameObject gameobject in gameObjectsToDisable)
        {
            gameobject.GetComponentInChildren<Button>().interactable = false;
        }
    }
}
