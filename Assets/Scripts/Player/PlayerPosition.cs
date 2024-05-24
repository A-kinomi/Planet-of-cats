using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    [SerializeField] Sprite spriteSide;
    [SerializeField] Sprite spriteDown;
    Sprite sprite;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;

        if (ItemInventory.instance.wasScene1)
        {
            this.transform.position = new Vector2(0f, -4f);
        }

        if (ItemInventory.instance.wasScene2)
        {
            this.transform.position = new Vector2(0f, 4f);
        }

        if (ItemInventory.instance.wasScene3)
        {
            this.transform.position = new Vector2(-8.5f, 0f);
            sprite = spriteSide;
        }

        if (ItemInventory.instance.wasScene4)
        {
            this.transform.position = new Vector2(0f, 4f);
            sprite = spriteDown;
        }

        if (ItemInventory.instance.wasScene5)
        {
            this.transform.position = new Vector2(8f, 0f);
            sprite = spriteSide;
            transform.localScale = new Vector2(-1f, 1f);
        }

        if(ItemInventory.instance.wasKilled)
        {
            this.transform.position = new Vector2(0f, 0f);
        }
    }
}
