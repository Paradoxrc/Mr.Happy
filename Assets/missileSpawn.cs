using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class missileSpawn : MonoBehaviour
    
{
    
    public GameObject missile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void spawnMissile()
    {
        Instantiate(missile, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        { 
        spawnMissile(); 
        }
        }
   
}
