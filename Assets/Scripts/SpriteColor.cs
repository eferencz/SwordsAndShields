using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColor : MonoBehaviour
{

    SpriteRenderer sprite;
    public TileManager.Owner owner;
    public TileManager tileManager;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void ResetTileColor()
    {
        sprite.color = Color.white;
    }

}
