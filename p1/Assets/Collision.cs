using UnityEngine;

public class Collision : MonoBehaviour
{
    public nnn var1;
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            var1.enabled = false;
            FindObjectOfType<Manager>().Endgame();
        }
    }
}
