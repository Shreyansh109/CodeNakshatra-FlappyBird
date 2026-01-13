using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * 2f) * Time.deltaTime;
        if (transform.position.x < -54f)
        {
            Destroy(gameObject);
        }
    }
}
