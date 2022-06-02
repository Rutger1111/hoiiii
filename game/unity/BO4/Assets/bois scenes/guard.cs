using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guard : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite lowSanity;
    float sf;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<sanity>().sanityfloat < 0.4f)
            spriteRenderer.sprite = lowSanity;
    }
}
