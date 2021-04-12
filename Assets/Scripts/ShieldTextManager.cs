using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldTextManager : MonoBehaviour
{
    public int scoreShield = 0;

    public void UpdateShieldScore()
    {
        GetComponent<Text>().text = "Shield Score: " + scoreShield;
    }

    void Update()
    {
        UpdateShieldScore();
    }
}
