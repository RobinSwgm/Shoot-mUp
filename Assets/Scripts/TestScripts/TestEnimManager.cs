using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnimManager : MonoBehaviour
{
    public GameObject[] _enemies;
    void Start()
    {
        Instantiate(_enemies[Random.Range(0, _enemies.Length)], Vector3.zero, Quaternion.identity);
        
    }

  
}
