using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting: MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab of the bullet
    public Transform firePointRotation;   // the position where bullets are spawned
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 20f; // speed of the bullet

 void Update()
 {
    RotateBulletSpawnPointTowardsMouse();

    // check for the 'fire1' input (left mouse button or spacebar by default)
    if (Input.GetButtonDown("Fire1"))
    {
        Shoot();
    }
 }

 void RotateBulletSpawnPointTowardsMouse()
 {
    // get the mouse position in screen space and convert it to to word space
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition).normalized;
    mousePosition.z = 0f; // ensure  z-axis is 0 for 2d space 
    //calculate  the direction  from the player to the mouse
    Vector2 direction = (mousePosition - firePointRotation.position).normalized;

    // calculate the angle to rotate the fire point (using Atan2 to get angle in degrees)
    float  angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

    // apply the roattion to the fire point 
    firePointRotation.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
 
}
void Shoot()
{
    // Instantiate the bullet at the fire point's position and rotation
    GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, firePointRotation.rotation);

    // get the rigidbody2d component from the bullet
    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

    // apply velocity to the bullet in the direction the fire point is facing
    rb.velocity = firePointRotation.right * bulletSpeed;

    Destroy(bullet, 10f);
}
}


