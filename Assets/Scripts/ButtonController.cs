using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject ResetButton;
    public TileManager tileManager;
    public SpriteColor tileColor0;
    public SpriteColor tileColor1;
    public SpriteColor tileColor2;
    public SpriteColor tileColor3;
    public SpriteColor tileColor4;
    public SpriteColor tileColor5;
    public SpriteColor tileColor6;
    public SpriteColor tileColor7;
    public SpriteColor tileColor8;


    public void HideResetButton()
    {
        ResetButton.SetActive(false);
    }

    public void RevealResetButton()
    {
        ResetButton.SetActive(true);
    }

    public void OnClick()
    {
        ResetButton.SetActive(false);

        tileManager.ResetGame();

        tileColor0.ResetTileColor();
        tileColor1.ResetTileColor();
        tileColor2.ResetTileColor();
        tileColor3.ResetTileColor();
        tileColor4.ResetTileColor();
        tileColor5.ResetTileColor();
        tileColor6.ResetTileColor();
        tileColor7.ResetTileColor();
        tileColor8.ResetTileColor();

    }

}
