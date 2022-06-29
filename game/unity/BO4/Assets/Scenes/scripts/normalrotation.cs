using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalrotation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.localScale = new Vector3(0.150000006f, 0.150000006f, 1);
        if (player.GetComponent<Player>().shoot == true)
        {
            transform.Rotate(0, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
            spriteRenderer.flipY = true;
        if(Input.GetKey(KeyCode.D))
            spriteRenderer.flipY = false;
    }
}
