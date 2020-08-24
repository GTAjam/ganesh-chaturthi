using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Text scoreup;
    public EndTrigger ee;
    // Update is called once per frame
    void Update()
    {
        scoreup.text = "MODAKS : " + Convert.ToString(ee.coin_count);
    }
}
