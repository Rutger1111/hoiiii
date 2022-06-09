using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    GameObject player;
    SpriteRenderer spriteRenderer;
    public Sprite lowsanity;
    public Sprite highsanity;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.Find("PLAYER");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<sanity>().sanityfloat < 0.4)
            ChangeSprite(lowsanity);
        else
            ChangeSprite(highsanity);

    }
    void ChangeSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }
}
