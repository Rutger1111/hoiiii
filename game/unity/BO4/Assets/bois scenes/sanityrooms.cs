using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanityrooms : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite lowSanity;
    public Sprite highSanity;
    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<sanity>().sanityfloat <= 0.5)
            ChangeSprite(lowSanity);
        else
            ChangeSprite(highSanity);
    }
    void ChangeSprite(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }
}
