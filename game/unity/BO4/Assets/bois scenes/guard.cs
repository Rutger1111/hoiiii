using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guard : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite lowsanity;
    public Sprite highsanity;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        player = GameObject.Find("PLAYER");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<sanity>().sanityfloat < 0.4f)        
            ChangeSprite(lowsanity);
        else
            ChangeSprite(highsanity);
    }
    void ChangeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }
}
