using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credit : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void Restarts()
    {
        SceneManager.LoadScene("Level01");
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
