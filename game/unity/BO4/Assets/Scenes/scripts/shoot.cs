using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float bulletSpeed = 10;
    public GameObject bulletPrefab;
    public Transform firepoint;
    public Rigidbody2D rb;
    public GameObject hoi;
    float newtime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Mouse0) && transform.parent.GetComponentInParent<Player>().shoot == true)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletSpeed, ForceMode2D.Impulse);
    }
}