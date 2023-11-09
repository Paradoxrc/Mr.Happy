using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileScript : MonoBehaviour
{
    public float missileSpeed;
    public Rigidbody2D MyRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            
            MyRigidbody.velocity = Vector2.right * missileSpeed * Time.deltaTime;
        
    }
}
