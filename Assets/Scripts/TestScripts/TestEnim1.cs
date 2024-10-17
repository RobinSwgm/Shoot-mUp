using UnityEngine;

public class TestEnim1 : MonoBehaviour
{
    private Vector2 startPosition;
    [SerializeField]
    private int speed = 2;
    [SerializeField]
    private int maxDistance = 2;
    private Vector2 newPosition;
    void Start()
    {
        newPosition = transform.position;
        startPosition = transform.position;
        
    }

    void Update()
    {
        transform.position = newPosition;
        newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
    }
}
