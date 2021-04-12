using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileManager : MonoBehaviour
{
    public Owner CurrentPlayer;
    public Tile[] Tiles = new Tile[9];

    private Text swordText;
    private Text shieldText;

    public ButtonController resetButton;
    public QuitButton quitButton;

    public enum Owner
    {
        None,
        Sword,
        Shield
    }

    private bool won;

    // Start is called before the first frame update
    void Start()
    {
        won = false;
        CurrentPlayer = Owner.Sword;
        swordText = GameObject.Find("SwordScore").GetComponent<Text>();
        shieldText = GameObject.Find("ShieldScore").GetComponent<Text>();

        resetButton.HideResetButton();
    }

    public void ChangePlayer()
    {
        if (CheckForWinner())
            return;

        if (CurrentPlayer == Owner.Sword)
            CurrentPlayer = Owner.Shield;
        else
            CurrentPlayer = Owner.Sword;
    }

    public bool CheckForWinner()
    {
        if (Tiles[0].owner == CurrentPlayer && Tiles[1].owner == CurrentPlayer && Tiles[2].owner == CurrentPlayer)
            won = true;
        else if (Tiles[0].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer && Tiles[8].owner == CurrentPlayer)
            won = true;
        else if (Tiles[0].owner == CurrentPlayer && Tiles[3].owner == CurrentPlayer && Tiles[6].owner == CurrentPlayer)
            won = true;
        else if (Tiles[1].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer && Tiles[7].owner == CurrentPlayer)
            won = true;
        else if (Tiles[2].owner == CurrentPlayer && Tiles[5].owner == CurrentPlayer && Tiles[8].owner == CurrentPlayer)
            won = true;
        else if (Tiles[2].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer && Tiles[6].owner == CurrentPlayer)
            won = true;
        else if (Tiles[3].owner == CurrentPlayer && Tiles[4].owner == CurrentPlayer && Tiles[5].owner == CurrentPlayer)
            won = true;
        else if (Tiles[6].owner == CurrentPlayer && Tiles[7].owner == CurrentPlayer && Tiles[8].owner == CurrentPlayer)
            won = true;

        if (won)
        {
            Debug.Log("Winner: " + CurrentPlayer);
            if (CurrentPlayer == Owner.Sword)
                swordText.GetComponent<SwordTextManager>().scoreSword += 1;
            else if (CurrentPlayer == Owner.Shield)
                shieldText.GetComponent<ShieldTextManager>().scoreShield += 1;

            resetButton.RevealResetButton();
            quitButton.RevealQuitButton();

            return true;
        }

        return false;
    }

    public void ResetGame()
    {
        won = false;
        CurrentPlayer = Owner.Sword;

        Tiles[0].owner = Owner.None;
        Tiles[1].owner = Owner.None;
        Tiles[2].owner = Owner.None;
        Tiles[3].owner = Owner.None;
        Tiles[4].owner = Owner.None;
        Tiles[5].owner = Owner.None;
        Tiles[6].owner = Owner.None;
        Tiles[7].owner = Owner.None;
        Tiles[8].owner = Owner.None;

    }
}
