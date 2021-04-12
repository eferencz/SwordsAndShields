using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordTextManager : MonoBehaviour
{
    public int scoreSword = 0;

    public void UpdateSwordScore()
    {
        GetComponent<Text>().text = "Sword Score: " + scoreSword;
    }

    void Update()
    {
        UpdateSwordScore();
    }
}
