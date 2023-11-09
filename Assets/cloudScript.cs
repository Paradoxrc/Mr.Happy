using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudScript : MonoBehaviour
{
    public float moveSpeed0 = 5;
    public float deadZone0 = -54;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.position = transform.position + (Vector3.left * moveSpeed0) * Time.deltaTime;
        if (transform.position.x < deadZone0)
        {
            Debug.Log("Cloud Deleted");
            Destroy(gameObject);
        }
    }
    
}
