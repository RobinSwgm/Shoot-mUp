using UnityEngine;

public class BGSpawn : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _bgTiles;
    [SerializeField]
    private GameObject _grid;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2)
        {
            Instantiate(_bgTiles[Random.Range(0, _bgTiles.Length)], Vector3.zero , Quaternion.identity, _grid.transform);
            timer = 0;
        }
    }
}
