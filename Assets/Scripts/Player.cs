using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1f;
    [SerializeField] private GameObject bulletPrefab;

public void Update()
{
    float direction = Input.GetAxisRaw("Horizontal");

    transform.Translate(direction * Time.deltaTime * movementSpeed, 0, 0);

    if (Input.GetKeyDown(KeyCode.Space))
    {
        Shoot();
    }
}
void Shoot()
{
    Instantiate(bulletPrefab, transform.position , transform.rotation);
}

}