using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawn : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate0 = 2;
    private float timer0 = 0;
    public float heightOffset0 = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer0 < spawnRate0)
        {
            timer0 = timer0 + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer0 = 0;
        }
    }
    void spawnCloud()
    {
        float lowestPoint0 = transform.position.y - heightOffset0;
        float highestPoint0 = transform.position.y + heightOffset0;
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint0, highestPoint0), 5), transform.rotation);
    }
}
