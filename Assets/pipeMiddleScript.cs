using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class pipeMiddleScript : MonoBehaviour


    
{
    

    public logicScipt logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScipt>();
    }

    // Update is called once per frame
    void Update()  
    {
       
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addscore();
        
    }
}
