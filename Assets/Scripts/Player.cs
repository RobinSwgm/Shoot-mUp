using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public InputAction playerControls;
    public InputAction playershoot;
    [SerializeField] private GameObject bulletPrefab;
    private bool shot;

    Vector2 moveDirection = Vector2.zero;

    private void OnEnable()
    {
        playerControls.Enable();
        playershoot.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
        playershoot.Disable();
    }

    private void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
        if (playershoot.ReadValue<float>() > 0f && !shot)
        {
            StartCoroutine(ShootBullet());
            //Shoot();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    IEnumerator ShootBullet()
    {
        shot = true;
        Instantiate(bulletPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.1f);
        shot = false;
    }

    void Shoot()
    {
       
    }

}