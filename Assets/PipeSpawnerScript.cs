using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 4f;
    private float timer = 0f;
    public float heightOffset = 10f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
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
            SpawnPipe();
            timer = 0;
        }
    }
    
    void SpawnPipe()
    {
        float lowerPoint = transform.position.y - heightOffset - 5;
        float upperPoint = transform.position.y + heightOffset;
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowerPoint, upperPoint), 0), transform.rotation);
    }
}
