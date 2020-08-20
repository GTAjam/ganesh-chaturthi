using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
