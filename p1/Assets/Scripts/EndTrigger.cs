using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public int coin_count = 0;
    public Manager manager;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            manager.CompleteLevel();
        }
        if(other.tag == "coin")
        {
            Debug.Log("Modak");
            other.GetComponent<AudioSource>().Play();
            other.GetComponent<MeshRenderer>().enabled = false;
            coin_count++;
        }
    }
}
