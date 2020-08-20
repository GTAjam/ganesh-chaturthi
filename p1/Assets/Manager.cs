using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    bool gamestat = false;
    public GameObject LevelUI;
    public GameObject gameover;
    public void CompleteLevel()
    {
        LevelUI.SetActive(true);
    }
    public void Endgame()
    {
        if(gamestat  == false)
        {
            gamestat = true;
            Debug.Log("Game Over");
            gameover.SetActive(true);
        }
    }
} 