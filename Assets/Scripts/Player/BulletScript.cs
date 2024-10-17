using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float Speed = 10;
    private void Start()
    {
        Destroy(gameObject, 4);
    }
    private void Update()
    {
        transform.Translate(0, Speed * Time.deltaTime * Speed, 0);
    }
}
