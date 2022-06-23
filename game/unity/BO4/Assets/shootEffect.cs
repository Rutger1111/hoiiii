using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootEffect : MonoBehaviour
{
    public float delay;
    public Sprite sprite1;
    public Sprite sprite2;
    public SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(ExampleCoroutine());
        }
    }
    IEnumerator ExampleCoroutine()
    {
        spriterenderer.sprite = sprite1;
        yield return new WaitForSeconds(delay);
        spriterenderer.sprite = sprite2;
        yield return new WaitForSeconds(delay);
        spriterenderer.sprite = null;
    }
}
