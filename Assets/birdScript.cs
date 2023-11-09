using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicScipt logic;
    public bool birdIsAlive = true;
    public float y_deadZone;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScipt>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdIsAlive==true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if(transform.position.y>22 || transform.position.y < -22)
        {
            logic.gameOver();
            birdIsAlive=false;
            
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        
    }
}
