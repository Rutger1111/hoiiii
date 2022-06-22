using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiFollow : MonoBehaviour
{
    [SerializeField] private Camera mCamera;
    [SerializeField] private GameObject enemy;
    bool ALIVE = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy)
            transform.position = mCamera.WorldToScreenPoint(enemy.transform.position);
    }
}
