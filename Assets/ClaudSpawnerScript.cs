using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaudSpawnerScript : MonoBehaviour
{
    public GameObject ClaudPrefab;
    public float spawnRate = 10f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnClaud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnClaud();
            timer = 0;
        }
    }

    void SpawnClaud()
    {
        Instantiate(ClaudPrefab, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
}
