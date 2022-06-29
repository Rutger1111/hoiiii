using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatearm : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            spriteRenderer.flipX = false;
        if(Input.GetKey(KeyCode.D))
            spriteRenderer.flipX = true;
    }
}
