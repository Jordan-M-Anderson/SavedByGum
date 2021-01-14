using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject gumballPrefab;
    public Camera cam;
    public Rigidbody2D rb2d;
    public Rigidbody2D player;

    Vector2 playerPos;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        playerPos = player.position;

        if (Input.GetButtonDown("Fire1")) {

            Shoot();

        }
        
    }

    private void FixedUpdate()
    {
        // Finds the direction to look at by subtracting the vector of the mouse by the vector of the gun
        Vector2 lookDir = mousePos - rb2d.position;

        // Finds the angle that the gun needs to face to look at the mousePos 
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        // Sets the guns angle
        rb2d.rotation = angle;

        transform.position = new Vector2(playerPos.x + .3954285f, playerPos.y - 0.200571f);
    }

    void Shoot() {

        Instantiate(gumballPrefab, firePoint.position, firePoint.rotation);

    }
}
